import { AbstractControl, ValidationErrors } from '@angular/forms';
export function courseLimitValidator(control: AbstractControl): ValidationErrors | null {
  const selected = control.value;

  if (!selected || selected.length < 1) {
    return { courseLimit: true }; // Minimum 1
  }

  if (selected.length > 2) {
    return { courseLimit: true }; // Maximum 2
  }

  return null;
}