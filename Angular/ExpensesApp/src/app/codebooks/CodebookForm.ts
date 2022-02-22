import { FormGroup } from "@angular/forms";

export abstract class CodebookForm {
    title: string = '';
    formGroup!: FormGroup;

    constructor() { }

    abstract setupForm(): void;

    abstract fillForm(): void;

    abstract save():void;

    protected setupTitle(id: number): void {
        this.title = id == undefined ? 'New' : 'Edit';
    }
}