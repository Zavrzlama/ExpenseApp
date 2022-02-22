import { MatDialog } from "@angular/material/dialog";

export abstract class CodebookOverview{

    dataSource:any[]=[];
    displayedColumns:string[]=[];

    abstract openDialog(id:number):void;
}