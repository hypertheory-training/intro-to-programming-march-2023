import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }


// import { NgModule } from '@angular/core';
// import { RouterModule, Routes } from '@angular/router';
// import { DashboardComponent } from './components/dashboard/dashboard.component';
// import { SupportComponent } from './components/support/support.component';

// const routes: Routes = [
//   {
//     path: 'dashboard',
//     component: DashboardComponent
//   },
//   {
//     path: 'support',
//     component: SupportComponent
//   },
//   {
//     path: '**',
//     redirectTo: 'dashboard'
//   }
// ];

// @NgModule({
//   imports: [RouterModule.forRoot(routes)],
//   exports: [RouterModule]
// })
// export class AppRoutingModule { }