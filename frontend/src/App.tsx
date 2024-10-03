import CoffeeItem from "./components/CoffeeItem";
import Header from "./components/Header";
import Intro from "./components/Intro";

export default function App() {
  return (
    <>
      <Header />
      <Intro />
      <div>
        <CoffeeItem />
        <CoffeeItem />
        <CoffeeItem />
        <CoffeeItem />
        <CoffeeItem />
        <CoffeeItem />
      </div>
    </>
  );
}
