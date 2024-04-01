import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BaseMasterPageComponent } from './common/components/master-pages/base-master-page/base-master-page.component';
import { SimpleMasterPageComponent } from './common/components/master-pages/simple-master-page/simple-master-page.component';

const routes: Routes = [
    { path: '', redirectTo: 'customers', pathMatch: 'full' },
    { 
        path: '',
        component: BaseMasterPageComponent,
        children: [
            {
                path: '',
                loadChildren: () => import('./customers/customers.module').then(m => m.CustomersModule),
                data: { module: 'customers' }
            },
        ] 
    },
    {
        path: 'products',
        component: SimpleMasterPageComponent,
        loadChildren: () => import('./products/products.module').then(m => m.ProductsModule)
    },
    {
        path: 'account',
        component: SimpleMasterPageComponent,
        loadChildren: () => import('./account/account.module').then(m => m.AccountModule)
    },
    { path: '**', redirectTo: 'customers', pathMatch: 'full' }
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes, {})],
  exports: [RouterModule],
})
export class AppRoutingModule {}
