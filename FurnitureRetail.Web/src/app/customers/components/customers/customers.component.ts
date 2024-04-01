import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/common/models/user';
import { CustomerService } from 'src/app/customers/services/customers.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.scss'],
})
export class CustomersComponent implements OnInit{
  customersList: User[];
  displayedColumns: string[] = ['firstName', 'lastName', "email", "numberOfSelledProducts", "rebate"];

  constructor(private customersService: CustomerService) {}

  async ngOnInit(){
    await this.customersService.getCustomers().subscribe((value) => {
        this.customersList = value;
      },
    );
  }

  getRebate(numberOfSelledProducts: number) {
    if(numberOfSelledProducts >= 100) {
      return 20;
    }

    else if(numberOfSelledProducts >=10) {
      return 10;
    }
    
    return 0;
  }
}
