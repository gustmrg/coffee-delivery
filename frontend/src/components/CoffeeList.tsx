import axios from "axios";
import { useEffect, useState } from "react";
import CoffeeItem from "./CoffeeItem";

export type Coffee = {
    id: number,
    name: string,
    description: string,
    temperature: number,
    category: number,
    hasAlcohol: boolean,
    hasMilk: boolean,
    price: number
}

function CoffeeList() {
    const API_ENDPOINT: string = 'https://localhost:7064/coffees/'
    const [coffeeList, setCoffeeList] = useState<Coffee[]>([]);

    useEffect(() => {
        axios.get(API_ENDPOINT)
            .then((response) => {
                setCoffeeList(response.data);
            }).catch((error) => {
                console.log('Erro na requisição: ', error);
            });
    }, [])

    console.log(coffeeList);

    return (
        <div>
            <h3 className="font-header text-xl antialiased mx-40 my-8">Nossos cafés</h3>
            {coffeeList.map((coffee) => {
                return <CoffeeItem
                    key={coffee.id}
                    id={coffee.id}
                    name={coffee.name}
                    description={coffee.description}
                    category={coffee.category}
                    price={coffee.price}
                    temperature={coffee.temperature}
                    hasAlcohol={coffee.hasAlcohol}
                    hasMilk={coffee.hasMilk}
                />
            })}
        </div>
    );
}

export default CoffeeList;