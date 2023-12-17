import { MapPin, ShoppingCart } from "@phosphor-icons/react";
import logoImage from "/assets/logo.svg"

function Header() {
    return (<header className="px-40 py-8 flex justify-between">
        <div>
            <img src={logoImage} />
        </div>
        <div className="flex justify-end items-center gap-3">
            <div className="p-2 gap-1 flex flex-row justify-center items-center bg-[#ebe5f9] rounded-md">
                <MapPin weight="fill" color="#8047f8" />
                <span className="text-[#4b2995] text-sm">Fortaleza, CE</span>
            </div>
            <div className="p-2 gap-1 bg-[#f1e9c9] rounded-md">
                <ShoppingCart size={20} weight="fill" color="#c47f17" />
            </div>
        </div>
    </header>);
}

export default Header;