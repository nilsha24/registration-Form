import { Injectable } from '@angular/core';
import { Employee } from '../employee';

@Injectable({
  providedIn: 'root'
})
export class EmpService {
  editdata: any;
  emplist: Employee[] = [   
  ];

  constructor() {}

  getEmployee() {
    return this.emplist;
  }
  addEmployee(data) {
    for (let i = 0; i < this.emplist.length; i++) {
      if (data == this.emplist[i]) {
        return this.emplist.splice(i, 1, data);
      }
    }
    this.emplist.push(data);
  }

  removeEmployee(data) {
    for (let i = 0; i < this.emplist.length; i++) {
      if (data == this.emplist[i]) {
        this.emplist.splice(i, 1);
      }
    }
  }

  editEmployee(data) {
    this.editdata = data;
  }
}
