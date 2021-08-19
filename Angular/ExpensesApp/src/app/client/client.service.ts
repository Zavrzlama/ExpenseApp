import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { ClientModel } from "./Models/ClientModel";

@Injectable(
    {
        providedIn: 'root'
    })

export class clientService {

    constructor(private http: HttpClient) { }

    getClients(): Observable<ClientModel[]> {
        const clientUrl = '';
        return this.http.get<ClientModel[]>(clientUrl).pipe(
            map((clients:ClientModel[]) => {
                return clients.map(client => ({
                    clientId:  client.clientId,
                    clientName: client.clientName,
                    description: client.description,
                    clientRoleid:  client.clientRoleid,
                    dateCreated: new Date(client.dateCreated),
                    dateUpdated: new Date(client.dateUpdated)
                }))
        }))
    }

    getClient(id: number): Observable<ClientModel> {
        const clientUrl = '';
        return this.http.get<ClientModel>(clientUrl);
    }
}