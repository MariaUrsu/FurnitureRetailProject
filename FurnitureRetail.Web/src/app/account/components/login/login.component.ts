import { Component, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { User } from 'src/app/common/models/user';
import { AuthService } from 'src/app/common/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent {
  emailFormControl = new FormControl('', [
    Validators.required,
    Validators.email,
  ]);
  passwordFormControl = new FormControl('', [Validators.required]);
  form: FormGroup;

  @Output() submitEM = new EventEmitter();

  constructor(private authService: AuthService) {
    this.form = new FormGroup({
      email: this.emailFormControl,
      password: this.passwordFormControl,
    });
  }

  submit() {
    if (this.form.valid) {
      this.authService.login(this.form.value as User);
      this.submitEM.emit(this.form.value);
    }
  }
}
