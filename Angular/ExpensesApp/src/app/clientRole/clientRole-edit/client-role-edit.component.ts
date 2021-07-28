import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ClientRolesService } from '../clientRoles.service';
import { Subscription } from 'rxjs';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ClientRole } from '../Models/clientRoleModel.component';

@Component({
  selector: 'exapp-client-role-edit',
  templateUrl: './client-role-edit.component.html',
  styleUrls: ['./client-role-edit.component.css']
})
export class ClientRoleEditComponent implements OnInit, OnDestroy {
  clientRoleForm!: FormGroup;
  clientRole = new ClientRole();

  pageTitle: string = '';
  errorMessage: string = '';
  errorRoleName: string = '';

  //clientRole: IClientRole | undefined;
  sub!: Subscription;
  constructor(private clientRoleService: ClientRolesService,
    private fb: FormBuilder,
    private activatedRoute: ActivatedRoute,
    private route: Router) {
  }

  ngOnInit(): void {
    this.clientRoleForm = this.fb.group({
      roleName: ['', Validators.required],
      description: ['', Validators.maxLength(100)]
    })

    //Role name validation
    const roleName = this.clientRoleForm.get('roleName');
    roleName?.valueChanges.subscribe(() => this.setMessage(roleName));

    //Get data from API an fill form
    this.sub = this.activatedRoute.paramMap.subscribe(
      params => {
        const id = params.get('id');
        this.getClientRole(Number(id));
      })
  }

  getClientRole(id: number): void {
    this.clientRoleService.getClientRole(id).subscribe({
      next: (clientRole: ClientRole) => {
        this.fillForm(clientRole)
      },
      error: err => this.errorMessage = err
    })
  }

  fillForm(clientRole: ClientRole): void {
    if (this.clientRoleForm) {
      this.clientRoleForm.reset();
    }

    this.clientRole = clientRole;

    if (this.clientRole.clientRoleId === 0) {
      this.pageTitle = 'New client role';
    } else {
      this.pageTitle = 'Edit client role';
    }

    this.clientRoleForm.patchValue({
      roleName: this.clientRole.roleName,
      description: this.clientRole.description
    });
  }

  saveClientRole(): void {
    if (this.clientRoleForm.valid) {
      if (this.clientRoleForm.dirty) {
        const editedClinetRole = { ...this.clientRole, ...this.clientRoleForm.value };

        if (editedClinetRole.clientRoleId == 0) {
          this.clientRoleService.createClientRole(editedClinetRole).subscribe({
            next: () => this.onSaveComplete,
            error: err => this.errorMessage = err
          })
        } else {
          this.clientRoleService.updateClientRole(editedClinetRole).subscribe({
            next: () => this.onSaveComplete(),
            error: err => this.errorMessage = err
          });
        }
      }
    } else {
      this.errorMessage = 'Correct validation errors!'
    }
    this.onSaveComplete();

  }

  onSaveComplete(): void {
    this.clientRoleForm.reset();
    this.route.navigate(['/clientRoles']);
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe;
  }

  setMessage(c: AbstractControl): void {
    this.errorMessage = '';
    if ((c.touched || c.dirty)) {
      if (c.hasError('required'))
        this.errorRoleName = 'Role name is required';
    }
  }

  onBack(): void {
    this.route.navigate(['/clientRoles']);
  }
}