import { Coffee, Package, ShoppingCart, Timer } from '@phosphor-icons/react'

import styles from './HeroItem.module.css'

export function HeroItem() {
    return (
        <div className={styles.hero_item}>
            <Coffee weight='fill' size={16} /> O café chega fresquinho até você
        </div>
    )
}