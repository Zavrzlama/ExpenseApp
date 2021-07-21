import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { createInjectableDefinitionMap } from "@angular/compiler/src/render3/partial/injectable";
import { Injectable } from "@angular/core";
import { Observable, of, throwError } from "rxjs";
import { catchError, map, tap } from "rxjs/operators";
import { IClientRole } from "./Models/IClientRole.component";
import { ClientRole } from './Models/clientRoleModel.component';

@Injectable({
    providedIn: 'root'
})
export class ClientRolesService {

    
    constructor(private http: HttpClient) { }

    getClientRoles(): Observable<IClientRole[]> {
        const urlGetRoles : string = 'https://localhost:44368//ExpensesApp/ClientRoles';
        //const urlGetRoles: string = './assets/clientRolesData.json';

        return this.http.get<IClientRole[]>(urlGetRoles).pipe(map((clientRoles: IClientRole[]) => {
            return clientRoles.map(clientRole => ({
                clientRoleId: clientRole.clientRoleId,
                roleName: clientRole.roleName,
                description: clientRole.description,
                dateCreated: new Date(clientRole.dateCreated),
                dateUpdated: new Date(clientRole.dateUpdated)
            }
            ))
        }),
            tap(data => console.log("All" + JSON.stringify(data))),
            catchError(this.handleError));
    }


    getClientRole(id: number): Observable<ClientRole> {

        if(id === 0){
            return of(new ClientRole)
        }

        const urlGetRole: string = 'https://localhost:44368//ExpensesApp/ClientRoles/' + id;

        return this.http.get<ClientRole>(urlGetRole).pipe(
            tap(data => console.log("All" + JSON.stringify(data))),
            catchError(this.handleError));
    }

    createClientRole(clientRole: ClientRole): Observable<ClientRole>{

        const urlPostRole: string = 'https://localhost:44368//ExpensesApp/ClientRoles/';
        const headers = new HttpHeaders({'Content-Type': 'application/json'});
        return this.http.post<ClientRole>(urlPostRole, clientRole, {headers:headers}).pipe(
            tap(data =>  console.log(JSON.stringify(data))),
            catchError(this.handleError))
    }

    updateClientRole(clientRole: ClientRole): Observable<ClientRole>{

        const urlPutRole: string = 'https://localhost:44368//ExpensesApp/ClientRoles/' + clientRole.clientRoleId;
        const headers = new HttpHeaders({'Content-Type': 'application/json'})
        return this.http.put<ClientRole>(urlPutRole, clientRole,{headers:headers});
    }

    private handleError(err: HttpErrorResponse) {
        let message = '';

        //Client-side or network error
        if (err.error instanceof ErrorEvent) {
            message = `An error occured: ${err.message}`;
        } else {
            //Backend or server error
            message = `An error occured: ${err.message}`;
        }
        console.log(message);

        return throwError(message)
    }
}