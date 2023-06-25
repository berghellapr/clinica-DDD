import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.css']
})
export class ClienteComponent implements OnInit {

  listClientes: any[] = [
    {nombre:'Paula', apellido:'Berghella', email:'paula@berghella.com'},
    {nombre:'Test', apellido:'ApellidoTest', email:'test@example.com'}
  ];

  form: FormGroup;

  constructor(private fb: FormBuilder,
    private toastr: ToastrService){
    this.form = this.fb.group({
      nombre: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(20)]],
      apellido: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(20)]],
      email: ['', [Validators.required, Validators.email]]
      })
    }
  

  ngOnInit(): void {
    
  }

  agregarCliente(){
    
    const cliente: any = {
      nombre: this.form.get('nombre')?.value,
      apellido: this.form.get('apellido')?.value,
      email: this.form.get('email')?.value
    }
    this.listClientes.push(cliente);
    this.toastr.success('El cliente fue registrado con éxito','Cliente registrado!',{positionClass:'toast-top-center'});
    //this.toastr.error('Ocurrió un error al registrar al cliente','Error',{positionClass:'toast-top-center'});
    this.form.reset();
    console.log(cliente);
  }

  eliminarCliente(index: number){
    this.listClientes.splice(index, 1);
    this.toastr.error('El cliente fue eliminado de nuestros registros correctamente','Cliente eliminado',{positionClass:'toast-top-center'});
  }

}
