import { Coffee, Package, ShoppingCart, Timer } from "@phosphor-icons/react";
import coffeeImage from "/assets/coffee-intro.png";

export default function Intro() {
    return (
        <div className="grid grid-cols-2 gap-y-2.5 justify-center justify-items-center justify-self-center">
            <div className="flex flex-col gap-y-2.5 align-self-center">
                <div className="flex flex-col gap-y-4 align-self-center">
                    <h1 className="font-header font-extrabold leading-tight text-5xl">Encontre o café perfeito para qualquer hora do dia</h1>
                    <p className="text-xl leading-tight antialiased text-amber-950">Com o Coffee Delivery você recebe seu café onde estiver, a qualquer hora</p>
                </div>
                <div className="">
                    <div className="grid grid-cols-2 gap-y-5 gap-x-10">
                        <div className="flex items-start content-center justify-center gap-2 space-y-2">
                            <div className="bg-amber-600 rounded-full p-2">
                                <ShoppingCart size={16} weight="fill" color="white" />
                            </div>
                            <p className="text-base font-normal antialiased text-amber-950">Compra simples e segura</p>
                        </div>
                        <div className="flex items-start content-center justify-center gap-2 space-y-2">
                            <div className="bg-yellow-950 rounded-full p-2">
                                <Package size={16} weight="fill" color="white" />
                            </div>
                            <p className="text-base font-normal antialiased text-amber-950">Embalagem mantém o café intacto</p>
                        </div>
                        <div className="flex items-start content-center justify-center gap-2 space-y-2">
                            <div className="bg-amber-400 rounded-full  border p-2">
                                <Timer size={16} weight="fill" color="white" />
                            </div>
                            <p className="text-base font-normal antialiased text-amber-950">Entrega rápida e rastreada</p>
                        </div>
                        <div className="flex items-start content-center justify-center gap-2 space-y-2">
                            <div className="bg-violet-600 rounded-full p-2">
                                <Coffee size={16} weight="fill" color="white" />
                            </div>
                            <p className="text-base font-normal antialiased text-amber-950">O café chega fresquinho até você</p>
                        </div>
                    </div>
                </div>
            </div>
            <div>
                <img src={coffeeImage} alt="Imagem de um copo de café com grãos ao fundo" />
            </div>
        </div>
    );
}