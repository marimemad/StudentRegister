import { Course } from './Course';

export interface Student {
  id: string;
  name: string;
  email: string;
  courses:Course[];
}
