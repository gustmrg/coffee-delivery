import axios from "axios";
import { useEffect, useState } from "react";
import CoffeeItem from "./CoffeeItem";

export type Coffee = {
  id: number;
  name: string;
  description: string;
  type: number;
  temperature: number;
  price: number;
  isAlcoholic: boolean;
  hasMilk: boolean;
};

function CoffeeList() {
  const url = import.meta.env.VITE_API_URL;
  const [coffeeList, setCoffeeList] = useState<Coffee[]>([]);

  useEffect(() => {
    axios
      .get(url)
      .then((response) => {
        setCoffeeList(response.data);
      })
      .catch((error) => {
        console.log("Erro na requisição: ", error);
      });
  }, []);

  console.log(coffeeList);

  return (
    <div className="px-16 grid grid-cols-6 space-x-6 space-y-8">
      {coffeeList.map((coffee) => {
        return (
          <CoffeeItem
            key={coffee.id}
            name={coffee.name}
            description={coffee.description}
            type={coffee.type}
            price={coffee.price}
            temperature={coffee.temperature}
            isAlcoholic={coffee.isAlcoholic}
            hasMilk={coffee.hasMilk}
          />
        );
      })}
    </div>
  );
}

export default CoffeeList;
