import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { OnCallDeveloperResponseModel } from 'src/app/models/oncalldeveloper'; 
@Component({
  selector: 'app-support',
  templateUrl: './support.component.html',
  styleUrls: ['./support.component.css']
})
export class SupportComponent {   onCallDeveloper$: Observable<OnCallDeveloperResponseModel>; 
  constructor(client:HttpClient) {
    this.onCallDeveloper$ = client.get<OnCallDeveloperResponseModel>('http://localhost:1338/oncalldeveloper');
  }
}