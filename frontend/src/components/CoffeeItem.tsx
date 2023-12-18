import { Coffee } from "./CoffeeList";

function CoffeeItem(props: Coffee) {
    return (
        <p>{props.name} {props.price}</p>
    );
}

export default CoffeeItem;