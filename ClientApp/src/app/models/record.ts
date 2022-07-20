import { Genre } from 'src/app/models/genre.enum';

export interface Record {
  artist: string;
  serialNumber: string;
  name: string;
  genre: Genre;
  imageUrl: string;
  releaseYear: string;
  tracks: { name: string; trackNo: number }[];
}

export type Records = Record[];
