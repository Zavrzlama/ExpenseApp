import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientRoleEditComponent } from './client-role-edit.component';

describe('ClientRoleEditComponent', () => {
  let component: ClientRoleEditComponent;
  let fixture: ComponentFixture<ClientRoleEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClientRoleEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ClientRoleEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
