import { Component, OnInit } from '@angular/core';
import { SelectControlValueAccessor } from '@angular/forms';

@Component({
  selector: 'app-ps1',
  templateUrl: './ps1.component.html',
  styleUrls: ['./ps1.component.css']
})
export class ps1Component {
  firstName:string='';
  lastName:string='';
  dateOfJoining:string='';

  setvalue(){
    this.firstName='Naren';
    this.lastName='S K';
    this.dateOfJoining='24.06.2022';
  }
}