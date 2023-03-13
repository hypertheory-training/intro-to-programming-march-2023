import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { OnCallDeveloperResponseModel } from '../models/oncalldeveloper';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core'; @Injectable()
export class OnCallDataService {
  constructor(private readonly client: HttpClient) {}   getCurrentHelpInformation(): Observable<OnCallDeveloperResponseModel> {
    return this.client.get<OnCallDeveloperResponseModel>(environment.onCallApi);
  }
}