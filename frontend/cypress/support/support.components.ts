import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { OnCallDeveloperResponseModel } from 'src/app/models/oncalldeveloper';
import { OnCallDataService } from 'src/app/services/oncall-data.service';

@Component({
  selector: 'app-support',
  templateUrl: './support.component.html',
  styleUrls: ['./support.component.css'],
})
export class SupportComponent {
  onCallDeveloper$: Observable<OnCallDeveloperResponseModel>;

  constructor(service: OnCallDataService) {
    this.onCallDeveloper$ = service.getCurrentHelpInformation();
  }
}