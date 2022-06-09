import { Component, OnInit } from '@angular/core';
import { Router, UrlHandlingStrategy } from '@angular/router';
import { User } from '../models/user';
import { LoginService } from '../services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
un:string;
pass:string;
  constructor(private route:Router,private loginService:LoginService) { }

  ngOnInit(): void {
  }
  login(un){
    let user:User = new User();
    user.username = this.un;
    user.password = this.pass;
    this.loginService.login(user).subscribe(data=>{
      user = data as User;
      if(user)
        alert("Welcome");
        localStorage.setItem("token",user.token);
        this.route.navigate(['student',this.un]);
    },
    (err=>{
        
        console.log(err);
        var error = err;
        alert(error.error.title+" "+error.error.description)
    })
    )
    
  }
}
