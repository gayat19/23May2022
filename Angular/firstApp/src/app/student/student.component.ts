import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  name:string;
  constructor(private activeRoute:ActivatedRoute) { 
    this.name="Ramu";
    this.name = this.activeRoute.snapshot.params["uname"];
  }

  ngOnInit(): void {
  }
  changeName(sname:string)
  {
    this.name = sname;
  }

}
