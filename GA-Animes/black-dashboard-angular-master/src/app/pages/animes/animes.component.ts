import { Component, OnInit } from "@angular/core";
import { PrimeNGConfig, SelectItem } from "primeng/api";

@Component({
  selector: "animes",
  templateUrl: "animes.component.html",
  styleUrls: ["animes.component.scss"]
})
export class AnimesComponent implements OnInit {
  constructor(private primengConfig: PrimeNGConfig) {}

  sortOptions: SelectItem[];
  selectedGeneros = [];
  
  selectedCity = null;
  generos = [
    { id: 1, label: 'Shonen' },
    { id: 2, label: 'Shoujo' },
    { id: 3, label: 'Seinen' },
    { id: 4, label: 'Josei' },
    { id: 5, label: 'Ecchi' },
    { id: 6, label: 'Harem' },
    { id: 7, label: 'Isekai' },
    { id: 8, label: 'Mecha' },
    { id: 9, label: 'Slice of Life' },
    { id: 10,label: 'Kodomomuke' },
    { id: 11,label: 'Iyashikei' }
];

  sortOrder: number;

  sortField: string;

  data = [
    {
        id: "1000",
        code: "f230fh0g3",
        name: "Bamboo Watch",
        description: "Product Description",
        image: "bamboo-watch.jpg",
        price: 65,
        category: "Accessories",
        quantity: 24,
        inventoryStatus: "INSTOCK",
        rating: 5
    },
    {
        id: "1001",
        code: "nvklal433",
        name: "Black Watch",
        description: "Product Description",
        image: "black-watch.jpg",
        price: 72,
        category: "Accessories",
        quantity: 61,
        inventoryStatus: "INSTOCK",
        rating: 4
    },
    {
        id: "1002",
        code: "zz21cz3c1",
        name: "Blue Band",
        description: "Product Description",
        image: "blue-band.jpg",
        price: 79,
        category: "Fitness",
        quantity: 2,
        inventoryStatus: "LOWSTOCK",
        rating: 3
    }]

  ngOnInit() {
    this.primengConfig.ripple = true;
  }

  onSortChange(event) {
    let value = event.value;

    if (value.indexOf('!') === 0) {
        this.sortOrder = -1;
        this.sortField = value.substring(1, value.length);
    }
    else {
        this.sortOrder = 1;
        this.sortField = value;
    }
}
}
