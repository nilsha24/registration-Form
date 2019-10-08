import { Component, OnInit } from '@angular/core';
import { EmpService } from '../services/employee.service';
import { Employee } from '../employee';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employeelist',
  templateUrl: './employeelist.component.html'
})
export class EmployeelistComponent implements OnInit {
  employeelist: Employee[];

  constructor(private emp: EmpService, private router: Router) {}

  ngOnInit() {
    this.employeelist = this.emp.getEmployee();
  }
  onDelete(data) {
    console.log(data.id);
    this.emp.removeEmployee(data);
  }

  onEdit(data) {
    this.emp.editEmployee(data);
    this.router.navigate(['/edit', data.id]);
  }
}
