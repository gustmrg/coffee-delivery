import { useState } from "react";
import { Minus, Plus, ShoppingCartSimple } from "@phosphor-icons/react";
import { Badge } from "./Badge";

interface CoffeeItemProps {
  name: string;
  description: string;
  type: number;
  temperature: number;
  price: number;
  isAlcoholic: boolean;
  hasMilk: boolean;
}

function CoffeeItem({ name, description, price }: CoffeeItemProps) {
  const [quantity, setQuantity] = useState(1);

  const handleMinusClick = () => {
    if (quantity === 1) return;

    setQuantity((state) => state - 1);
  };

  const handlePlusClick = () => {
    setQuantity((state) => state + 1);
  };

  return (
    <div className="flex flex-col items-center p-4 bg-base-card rounded-lg space-y-4 w-[256px] h-[360px] mt-4 ml-6">
      <div className="">
        <img src="/assets/expresso.png" />
      </div>
      <Badge label="tradicional" />
      <div className="flex flex-col items-center space-y-2">
        <h3 className="font-baloo font-bold text-xl text-base-subtitle antialiased">
          {name}
        </h3>
        <p className="text-base-label">{description}</p>
      </div>
      <div className="flex flex-row items-center justify-center p-2 space-x-4">
        <p className="text-base-text">
          R$ <span className="font-bold text-2xl">{price.toFixed(2)}</span>
        </p>
        <div className="flex flex-row space-x-2">
          <div className="w-[72px] h-[38px] space-x-2 flex items-center justify-center bg-base-button rounded-lg">
            <button onClick={handleMinusClick} className="text-purple-500">
              <Minus size={14} />
            </button>
            <span className="text-base-title text-base">{quantity}</span>
            <button onClick={handlePlusClick} className="text-purple-500">
              <Plus size={14} />
            </button>
          </div>
          <div className="flex items-center justify-center text-base-card bg-purple-700 hover:bg-purple-500 rounded-lg p-2 h-10 w-10">
            <ShoppingCartSimple size={24} weight="fill" />
          </div>
        </div>
      </div>
    </div>
  );
}

export default CoffeeItem;
