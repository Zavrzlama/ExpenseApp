import { Component, OnDestroy, OnInit } from "@angular/core";
import { FormBuilder, FormGroup } from "@angular/forms";
import { Router } from "@angular/router";
import { Subscription } from "rxjs";
import { ClientRolesService } from "../clientRoles.service";
import { IClientRole } from "../Models/IClientRole.component";

@Component({
    selector: 'exapp-clientRoles',
    templateUrl: './clientRole-list.component.html'
})

export class ClientRoleListComponent implements OnInit, OnDestroy {

    pageTitle: string = 'Client roles';
    errorMessage: string = '';
    sub!: Subscription;
    filteredClientRoles: IClientRole[] = [];
    filterForm!: FormGroup;

    private _clientRoleFilter: string = '';
    private _clientRoles: IClientRole[] = [];

    constructor(
        private clientRoleService: ClientRolesService,
        private fb: FormBuilder,
        private route: Router) { }

    set clientRoleFilter(value: string) {
        this._clientRoleFilter = value;
        this.filteredClientRoles = this.getFilteredClientRoles(value);
    }
    get clientRoleFilter(): string {
        return this._clientRoleFilter;
    }

    getFilteredClientRoles(filterBy: string): IClientRole[] {
        filterBy = filterBy.toLowerCase();
        return this._clientRoles.filter((clientRole: IClientRole) => clientRole.roleName.toLowerCase().includes(filterBy));
    };

    ngOnInit(): void {
        //Form builder
        this.filterForm = this.fb.group(
            { filter: '' })

        //Get ClientRoles from API 
        this.sub = this.clientRoleService.getClientRoles().subscribe({
            next: clientRoles => {
                this._clientRoles = clientRoles
                this.filteredClientRoles = this._clientRoles
            },
            error: err => this.errorMessage = err
        });
        
        //Form field (filter) validation
        const filter = this.filterForm.get("filter");
        filter?.valueChanges.subscribe(value => this.filteredClientRoles = this.getFilteredClientRoles(value));
    }

    ngOnDestroy() {
        this.sub.unsubscribe;
    }

    onNew(): void {
        this.route.navigate(['clientRole/0/edit']);
    }
}