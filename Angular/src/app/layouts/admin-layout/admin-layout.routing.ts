import { Routes } from '@angular/router';

import { HomeComponent } from '../../home/home.component';
import { UserComponent } from '../../user/user.component';
import { TablesComponent } from '../../tables/tables.component';
import { TypographyComponent } from '../../typography/typography.component';
import { IconsComponent } from '../../icons/icons.component';
import { MapsComponent } from '../../maps/maps.component';
import { NotificationsComponent } from '../../notifications/notifications.component';
import { UpgradeComponent } from '../../upgrade/upgrade.component';
import { AddCategoryComponent } from '../add-category/add-category.component';
import { AddMerchantComponent } from 'src/app/add-merchant/add-merchant.component';

export const AdminLayoutRoutes: Routes = [
    { path: 'dashboard',      component: HomeComponent },
    { path: 'user',           component: UserComponent },
    { path: 'transactions',   component: TablesComponent },
    { path: 'vouchers',       component: TypographyComponent },
    { path: 'icons',          component: IconsComponent },
    { path: 'make-payment',   component: MapsComponent },
    { path: 'add-category',   component: AddCategoryComponent },
    { path: 'add-merchant',   component: AddMerchantComponent },
    { path: 'notifications',  component: NotificationsComponent },
    { path: 'upgrade',        component: UpgradeComponent },
];
