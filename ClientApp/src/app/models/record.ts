export interface Record {
  id: number;
  artist: string;
  serialNumber: string;
  name: string;
  genre: number;
  imageUrl: string;
  releaseYear: string;
  tracks: { name: string; trackNo: number }[];
}

export type Records = Record[];
