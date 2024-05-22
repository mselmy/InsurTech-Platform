import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { Config } from 'datatables.net-dt';
import 'datatables.net-responsive';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-registration-requests',
  standalone: false,
  animations: [appModuleAnimation()],
  templateUrl: './registration-requests.component.html',
  styleUrl: './registration-requests.component.css'
})
export class RegistrationRequestsComponent implements OnInit
{
dtOptions: Config = {};
constructor(private router: Router) { }
  ngOnInit(): void {
    this.dtOptions = {
      columnDefs: [
        { orderable: false, targets: -1 }, // Disables sorting on the last column
        // make text align to left for all columns
        { className: 'dt-left', targets: '_all' }
      ],
      responsive: true
    };
  }

  showApproveAlert() {
    Swal.fire({
      title: "Approve Request",
      text: "Are you sure you want to approve this request?",
      icon: "warning",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Yes"
    }).then((result) => {
      if (result.isConfirmed) {
        Swal.fire({
          title: "Approved!",
          text: "The request has been approved.",
          icon: "success"
        });
      }
    });
  }

  showDeclineAlert() {
    Swal.fire({
      title: "Decline Request",
      text: "Are you sure you want to decline this request?",
      icon: "error",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Yes"
    }).then((result) => {
      if (result.isConfirmed) {
        Swal.fire({
          title: "Declined!",
          text: "The request has been declined.",
          icon: "success"
        });
      }
    });
    // route to details
    this.router.navigate(['/app/registration-requests/details']);
  }

}
