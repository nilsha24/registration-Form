import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { EmpService } from '../services/employee.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-createemployee',
  templateUrl: './createemployee.component.html',
  styleUrls: ['./createemployee.component.css']
})
export class CreateemployeeComponent implements OnInit {
  employee = new Employee();
  editEmployee = new Employee();

  constructor(
    private emp: EmpService,
    private router: Router,
    private _route: ActivatedRoute
  ) {}

  ngOnInit() {
    this._route.paramMap.subscribe(param => {
      const id = +param.get('id');
      this.getEmployee(id);
      console.log(id);
    });
  }

  private getEmployee(id: number) {
    if (id === 0) {
      this.editEmployee = {
        id: null,
        name: null,
        GroupName: null,
        ModifiedDate: null
      };
    } else {
      this.editEmployee = this.emp.editdata;
    }
  }
  onSubmit() {
    console.log(this.editEmployee);
    this.emp.addEmployee(this.editEmployee);
    this.router.navigate(['/employeelist']);
  }
}
