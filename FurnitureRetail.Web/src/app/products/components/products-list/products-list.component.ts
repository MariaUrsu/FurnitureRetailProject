import { Component, OnInit } from '@angular/core';
import { productsService } from '../../services/products.service';
import { Product } from 'src/app/common/models/product';

@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.scss']
})
export class ProductsListComponent implements OnInit {
  products: Product[];
  displayedColumns: string[] = ['name', 'price'];

  constructor(private productService: productsService) {}

  async ngOnInit() {
    await this.productService.getProducts().subscribe((value) => {
      this.products = value;
    });
  }
}
