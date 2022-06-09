import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { User } from "../models/user";

@Injectable()
export class LoginService{
    constructor(private httpClient:HttpClient){

    }
    login(user:User){
        return this.httpClient.post("http://localhost:40496/api/User/Login",user)
    }
}