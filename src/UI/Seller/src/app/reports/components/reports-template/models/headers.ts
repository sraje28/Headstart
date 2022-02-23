export const buyerLocation = [
  { value: 'ID', path: 'ID' },
  { value: 'Street 1', path: 'Street1' },
  { value: 'Street 2', path: 'Street2' },
  { value: 'City', path: 'City' },
  { value: 'State', path: 'State' },
  { value: 'Zip', path: 'Zip' },
  { value: 'Country', path: 'Country' },
  { value: 'Company Name', path: 'CompanyName' },
  { value: 'Primary Contact Name', path: 'xp.PrimaryContactName' },
  { value: 'Email', path: 'xp.Email' },
  { value: 'Phone', path: 'Phone' },
  { value: 'Opening Date', path: 'xp.OpeningDate' },
  { value: 'Billing Number', path: 'xp.BillingNumber' },
  { value: 'Status', path: 'xp.Status' },
  { value: 'Legal Entity', path: 'xp.LegalEntity' },
]

export const salesOrderDetail = [
  { value: 'ID', path: 'Data.ID' },
  { value: 'Brand ID', path: 'Data.BillingAddress.ID' },
  { value: 'Brand Name', path: 'BrandName' },
  { value: 'Order Type', path: 'Data.xp.OrderType' },
  { value: 'Order Date', path: 'Data.DateSubmitted' },
  { value: 'Date Completed', path: 'Data.DateCompleted' },
  { value: 'Total', path: 'Data.Total' },
  { value: 'Tax', path: 'Data.TaxCost' },
  { value: 'Shipping/Freight', path: 'Data.ShippingCost' },
  { value: 'Discount', path: 'Data.PromotionDiscount' },
  { value: 'PromoCode', path: 'Promos.PromoCode' },
  { value: 'Supplier Specific Promo', path: 'Promos.SupplierSpecific' },
  { value: 'Promo Supplier Name', path: 'Promos.SupplierName' },
  { value: 'Order Level Promo', path: 'Promos.OrderLevelPromo' },
  { value: 'Line Item Level Promo', path: 'Promos.LineItemLevelPromo' },
  { value: 'Subtotal', path: 'Data.Subtotal' },
  { value: 'Order Currency', path: 'Data.xp.Currency' },
  { value: 'Submitted Order Status', path: 'Data.xp.SubmittedOrderStatus' },
  { value: 'Shipping Status', path: 'Data.xp.ShippingStatus' },
  { value: 'Payment Method', path: 'Data.xp.PaymentMethod' },
  { value: 'Billing Street 1', path: 'Data.BillingAddress.Street1' },
  { value: 'Billing Street 2', path: 'Data.BillingAddress.Street2' },
  { value: 'Billing City', path: 'Data.BillingAddress.City' },
  { value: 'Billing State', path: 'Data.BillingAddress.State' },
  { value: 'Billing Zip', path: 'Data.BillingAddress.Zip' },
  { value: 'Billing Country', path: 'Data.BillingAddress.Country' },
  { value: 'Billing Number', path: 'Data.BillingAddress.xp.BillingNumber' },
  { value: 'Club Number', path: 'Data.BillingAddress.xp.LocationID' },
  { value: 'Club Name', path: 'Data.BillingAddress.AddressName' },
  { value: 'User ID', path: 'Data.FromUser.ID' },
  { value: 'Username', path: 'Data.FromUser.Username' },
  { value: 'First Name', path: 'Data.FromUser.FirstName' },
  { value: 'Last Name', path: 'Data.FromUser.LastName' },
  { value: 'Email', path: 'Data.FromUser.Email' },
  { value: 'Phone', path: 'Data.FromUser.Phone' },
  { value: 'Shipping First Name', path: 'Data.xp.ShippingAddress.FirstName' },
  { value: 'Shipping Last Name', path: 'Data.xp.ShippingAddress.LastName' },
  { value: 'Shipping Street 1', path: 'Data.xp.ShippingAddress.Street1' },
  { value: 'Shipping Street 2', path: 'Data.xp.ShippingAddress.Street2' },
  { value: 'Shipping City', path: 'Data.xp.ShippingAddress.City' },
  { value: 'Shipping State', path: 'Data.xp.ShippingAddress.State' },
  { value: 'Shipping Zip', path: 'Data.xp.ShippingAddress.Zip' },
  { value: 'Shipping Country', path: 'Data.xp.ShippingAddress.Country' },
]

export const purchaseOrderDetail = [
  { value: 'ID', path: 'Data.ID' },
  { value: 'Supplier ID', path: 'Data.ToCompanyID' },
  { value: 'Supplier Name', path: 'SupplierName' },
  { value: 'Order Type', path: 'Data.xp.OrderType' },
  { value: 'Order Date', path: 'Data.DateSubmitted' },
  { value: 'Date Completed', path: 'Data.DateCompleted' },
  { value: 'PromoCode', path: 'Promos.PromoCode' },
  { value: 'Supplier Specific Promo', path: 'Promos.SupplierSpecific' },
  { value: 'Promo Supplier Name', path: 'Promos.SupplierName' },
  { value: 'Order Level Promo', path: 'Promos.OrderLevelPromo' },
  { value: 'Line Item Level Promo', path: 'Promos.LineItemLevelPromo' },
  { value: 'Total', path: 'Data.Total' },
  { value: 'Brand ID', path: 'Data.ShippingAddressID' },
  { value: 'Brand Name', path: 'BrandName' },
  { value: 'Order Currency', path: 'Data.xp.Currency' },
  { value: 'Status', path: 'Data.Status' },
  { value: 'Submitted Order Status', path: 'Data.xp.SubmittedOrderStatus' },
  { value: 'Shipping Status', path: 'Data.xp.ShippingStatus' },
  { value: 'Payment Method', path: 'Data.xp.PaymentMethod' },
  { value: 'User ID', path: 'Data.FromUser.ID' },
  { value: 'Username', path: 'Data.FromUser.Username' },
  { value: 'First Name', path: 'Data.FromUser.FirstName' },
  { value: 'Last Name', path: 'Data.FromUser.LastName' },
  { value: 'Email', path: 'Data.FromUser.Email' },
  { value: 'Phone', path: 'Data.FromUser.Phone' },
  { value: 'Location ID', path: 'Data.BillingAddress.xp.LocationID' },
  { value: 'Shipping First Name', path: 'Data.xp.ShippingAddress.FirstName' },
  { value: 'Shipping Last Name', path: 'Data.xp.ShippingAddress.LastName' },
  { value: 'Shipping Street 1', path: 'Data.xp.ShippingAddress.Street1' },
  { value: 'Shipping Street 2', path: 'Data.xp.ShippingAddress.Street2' },
  { value: 'Shipping City', path: 'Data.xp.ShippingAddress.City' },
  { value: 'Shipping State', path: 'Data.xp.ShippingAddress.State' },
  { value: 'Shipping Zip', path: 'Data.xp.ShippingAddress.Zip' },
  { value: 'Shipping Country', path: 'Data.xp.ShippingAddress.Country' },
  { value: 'Ship From Address', path: 'ShipFromAddressID' },
  { value: 'Ship Method', path: 'ShipMethod' },
]

export const lineItemDetail = [
  { value: 'Order ID', path: 'HSOrder.ID' },
  { value: 'Brand ID', path: 'HSOrder.BillingAddressID' },
  { value: 'Brand Name', path: 'HSLineItem.xp.BrandName' },
  { value: 'Supplier ID', path: 'HSLineItem.SupplierID' },
  { value: 'Supplier Name', path: 'HSLineItem.xp.SupplierName' },
  { value: 'Order Type', path: 'HSOrder.xp.OrderType' },
  { value: 'Order Date', path: 'HSOrder.DateSubmitted' },
  { value: 'Date Complete', path: 'HSOrder.DateCompleted' },
  { value: 'Total', path: 'HSOrder.Total' },
  { value: 'Tax', path: 'HSOrder.TaxCost' },
  { value: 'Shipping/Freight', path: 'HSOrder.ShippingCost' },
  { value: 'Discount', path: 'HSOrder.PromotionDiscount' },
  { value: 'Subtotal', path: 'HSOrder.Subtotal' },
  { value: 'Order Currency', path: 'HSOrder.xp.Currency' },
  { value: 'Sales Order Status', path: 'HSOrder.Status' },
  {
    value: 'Submitted Order Status',
    path: 'HSOrder.xp.SubmittedOrderStatus',
  },
  { value: 'Payment Method', path: 'HSOrder.xp.PaymentMethod' },
  { value: 'Line Item ID', path: 'HSLineItem.ID' },
  { value: 'Line Unit Price', path: 'HSLineItem.UnitPrice' },
  { value: 'Line Total', path: 'HSLineItem.LineTotal' },
  { value: 'Line Subtotal', path: 'HSLineItem.LineSubtotal' },
  { value: 'Line Tax', path: 'HSLineItem.xp.Tax' },
  { value: 'Product ID', path: 'HSLineItem.ProductID' },
  { value: 'Product Name', path: 'HSLineItem.Product.Name' },
  { value: 'Product Type', path: 'HSLineItem.Product.xp.ProductType' },
  { value: 'Variant ID', path: 'HSLineItem.Variant.ID' },
  { value: 'Variant Name', path: 'HSLineItem.Variant.xp.SpecCombo' },
  { value: 'Quantity', path: 'HSLineItem.Quantity' },
  { value: 'Tax Code', path: 'HSLineItem.Product.xp.Tax.Code' },
  { value: 'Is Resale?', path: 'HSLineItem.Product.xp.IsResale' },
  {
    value: 'Unit of Measure Qty',
    path: 'HSLineItem.Product.xp.UnitOfMeasure.Qty',
  },
  {
    value: 'Unit of Measure',
    path: 'HSLineItem.Product.xp.UnitOfMeasure.Unit',
  },
  {
    value: 'Has Variants?',
    path: 'HSLineItem.Product.xp.HasVariants',
  },
  { value: 'Ship Method', path: 'HSLineItem.xp.ShipMethod' },
  {
    value: 'Shipping First Name',
    path: 'HSLineItem.ShippingAddress.FirstName',
  },
  {
    value: 'Shipping Last Name',
    path: 'HSLineItem.ShippingAddress.LastName',
  },
  {
    value: 'Shipping Street 1',
    path: 'HSLineItem.ShippingAddress.Street1',
  },
  {
    value: 'Shipping Street 2',
    path: 'HSLineItem.ShippingAddress.Street2',
  },
  { value: 'Shipping City', path: 'HSLineItem.ShippingAddress.City' },
  {
    value: 'Shipping State',
    path: 'HSLineItem.ShippingAddress.State',
  },
  { value: 'Shipping Zip', path: 'HSLineItem.ShippingAddress.Zip' },
  {
    value: 'Shipping Country',
    path: 'HSLineItem.ShippingAddress.Country',
  },
  {
    value: 'Billing Street 1',
    path: 'HSOrder.BillingAddress.Street1',
  },
  {
    value: 'Billing Street 2',
    path: 'HSOrder.BillingAddress.Street2',
  },
  { value: 'Billing City', path: 'HSOrder.BillingAddress.City' },
  { value: 'Billing State', path: 'HSOrder.BillingAddress.State' },
  { value: 'Billing Zip', path: 'HSOrder.BillingAddress.Zip' },
  { value: 'Billing Country', path: 'HSOrder.BillingAddress.Country' },
  {
    value: 'Billing Number',
    path: 'HSOrder.BillingAddress.xp.BillingNumber',
  },
  {
    value: 'Club Number',
    path: 'HSOrder.BillingAddress.xp.LocationID',
  },
  { value: 'User ID', path: 'HSOrder.FromUser.ID' },
  { value: 'Username', path: 'HSOrder.FromUser.Username' },
  { value: 'First Name', path: 'HSOrder.FromUser.FirstName' },
  { value: 'Last Name', path: 'HSOrder.FromUser.LastName' },
  { value: 'Email', path: 'HSLineItem.ShippingAddress.xp.Email' },
  { value: 'Phone', path: 'HSOrder.FromUser.Phone' },
  {
    value: 'Status Submitted',
    path: 'HSLineItem.xp.StatusByQuantity.Submitted',
  },
  {
    value: 'Status Backordered',
    path: 'HSLineItem.xp.StatusByQuantity.Backordered',
  },
  {
    value: 'Status CancelRequested',
    path: 'HSLineItem.xp.StatusByQuantity.CancelRequested',
  },
  {
    value: 'Status CancelDenied',
    path: 'HSLineItem.xp.StatusByQuantity.CancelDenied',
  },
  { value: 'Status Complete', path: 'HSLineItem.xp.StatusByQuantity.Complete' },
  {
    value: 'Status ReturnRequested',
    path: 'HSLineItem.xp.StatusByQuantity.ReturnRequested',
  },
  {
    value: 'Status ReturnDenied',
    path: 'HSLineItem.xp.StatusByQuantity.ReturnDenied',
  },
  { value: 'Status Returned', path: 'HSLineItem.xp.StatusByQuantity.Returned' },
  { value: 'Status Canceled', path: 'HSLineItem.xp.StatusByQuantity.Canceled' },
  { value: 'Status Open', path: 'HSLineItem.xp.StatusByQuantity.Open' },
  { value: 'Promotion Discount', path: 'HSLineItem.PromotionDiscount' },
]

export const productDetail = [
  { value: 'Product ID', path: 'ProductID' },
  { value: 'Product Name', path: 'Product.Name' },
  { value: 'Active', path: 'Data.Active' },
  { value: 'Variant ID', path: 'Data.VariantID' },
  { value: 'Variant Name', path: 'Data.VariantName' },
  { value: 'Variant Active', path: 'Data.Variant.Active' },
  { value: 'Spec Combo', path: 'Data.SpecCombo' },
  { value: 'Spec Name', path: 'Data.SpecName' },
  { value: 'Spec Option Value', path: 'Data.SpecOptionValue' },
  { value: 'Spec Price Markup', path: 'Data.SpecPriceMarkup' },
  { value: 'Variant Level Tracking', path: 'Data.VariantLevelTracking' },
  { value: 'Inventory Qty', path: 'Data.InventoryQuantity' },
  { value: 'Inventory Last Updated', path: 'Data.InventoryLastUpdated' },
  { value: 'Inventory Order Can Exceed', path: 'Data.InventoryOrderCanExceed' },
  { value: 'Ship Weight', path: 'Product.ShipWeight' },
  { value: 'Ship Height', path: 'Product.ShipHeight' },
  { value: 'Ship Width', path: 'Product.ShipWidth' },
  { value: 'Ship Length', path: 'Product.ShipLength' },
  { value: 'Product Description', path: 'Product.Description' },
  { value: 'Ship From Address ID', path: 'Product.ShipFromAddressID' },
  { value: 'Default Price Schedule', path: 'Product.DefaultPriceScheduleID' },
  { value: 'Price Schedule ID', path: 'Data.PriceScheduleID' },
  { value: 'Price Schedule Name', path: 'Data.PriceScheduleName' },
  { value: 'Price', path: 'Data.Price' },
  { value: 'Cost', path: 'Data.Cost' },
  { value: 'Supplier ID', path: 'Data.SupplierID' },
  { value: 'Supplier Name', path: 'Data.SupplierName' },
  { value: 'Status', path: 'Data.Status' },
  { value: 'Note', path: 'Data.Note' },
  { value: 'Tax Category', path: 'Data.TaxCategory' },
  { value: 'Tax Code', path: 'Data.TaxCode' },
  { value: 'Tax Description', path: 'Data.TaxDescription' },
  { value: 'Unit of Measure Qty', path: 'Data.UnitOfMeasureQty' },
  { value: 'Unit of Measure', path: 'Data.UnitOfMeasure' },
  { value: 'Product Type', path: 'Data.ProductType' },
  { value: 'Size Tier', path: 'Data.SizeTier' },
  { value: 'Resale', path: 'Data.Resale' },
  { value: 'Currency', path: 'Data.Currency' },
  { value: 'Artwork Required', path: 'Data.ArtworkRequired' },
  { value: '3 Month Sales', path: 'ProductSales.ThreeMonthQuantity' },
  { value: '6 Month Sales', path: 'ProductSales.SixMonthQuantity' },
  { value: '12 Month Sales', path: 'ProductSales.TwelveMonthQuantity' },
  { value: '3 Month Order Total', path: 'ProductSales.ThreeMonthTotal' },
  { value: '6 Month Order Total', path: 'ProductSales.SixMonthTotal' },
  { value: '12 Month Order Total', path: 'ProductSales.TwelveMonthTotal' },
]

export const rmaDetail = [
  { value: 'Order ID', path: 'RMA.SourceOrderID' },
  { value: 'Supplier ID', path: 'RMA.SupplierID' },
  { value: 'Supplier Name', path: 'RMA.SupplierName' },
  { value: 'Date Created', path: 'RMA.DateCreated' },
  { value: 'Date Completed', path: 'RMA.DateComplete' },
  { value: 'RMA Number', path: 'RMA.RMANumber' },
  { value: 'Type', path: 'RMA.Type' },
  { value: 'RMA Status', path: 'RMA.Status' },
  { value: 'Shipping Credited', path: 'RMA.ShippingCredited' },
  { value: 'Total Credited', path: 'RMA.TotalCredited' },
  { value: 'Line Item ID', path: 'RMALineItem.ID' },
  { value: 'Reason', path: 'RMALineItem.Reason' },
  { value: 'Quantity Processed', path: 'RMALineItem.QuantityProcessed' },
  { value: 'Line Status', path: 'RMALineItem.Status' },
  { value: 'Line Total Refund', path: 'RMALineItem.LineTotalRefund' },
  { value: 'IsResolved', path: 'RMALineItem.IsResolved' },
  { value: 'IsRefunded', path: 'RMALineItem.IsRefunded' },
  { value: 'Comment', path: 'RMALineItem.Comment' },
]

export const shipmentDetail = [
  { value: 'Order ID', path: 'OrderID' },
  { value: 'Order Date', path: 'DateSubmitted' },
  { value: 'Submitted Order Status', path: 'SubmittedOrderStatus' },
  { value: 'Shipping Status', path: 'ShippingStatus' },
  { value: 'Line Item ID', path: 'LineItemID' },
  { value: 'Supplier ID', path: 'SupplierID' },
  { value: 'Supplier Name', path: 'SupplierName' },
  { value: 'Supplier Shipping Cost', path: 'SupplierShippingCost' },
  { value: 'Buyer Shipping Cost', path: 'BuyerShippingCost' },
  { value: 'Buyer Shipping Tax', path: 'BuyerShippingTax' },
  { value: 'Buyer Shipping Total', path: 'BuyerShippingTotal' },
  { value: 'Shipping Cost Difference', path: 'ShippingCostDifference' },
  { value: 'Product ID', path: 'ProductID' },
  { value: 'Product Name', path: 'ProductName' },
  { value: 'Quantity', path: 'Quantity' },
  { value: 'Quantity Shipped', path: 'QuantityShipped' },
  { value: 'Line Total', path: 'LineTotal' },
  { value: 'Ship To Company Name', path: 'ShipToCompanyName' },
  { value: 'Ship To Street 1', path: 'ShipToStreet1' },
  { value: 'Ship To Street 2', path: 'ShipToStreet2' },
  { value: 'Ship To City', path: 'ShipToCity' },
  { value: 'Ship To State', path: 'ShipToState' },
  { value: 'Ship To Zip', path: 'ShipToZip' },
  { value: 'Ship To Country', path: 'ShipToCountry' },
  { value: 'Ship Weight', path: 'ShipWeight' },
  { value: 'Ship Width', path: 'ShipWidth' },
  { value: 'Ship Height', path: 'ShipHeight' },
  { value: 'Ship Length', path: 'ShipLength' },
  { value: 'Size Tier', path: 'SizeTier' },
  { value: 'From User First Name', path: 'FromUserFirstName' },
  { value: 'From User Last Name', path: 'FromUserLastName' },
  { value: 'Location ID', path: 'LocationID' },
  { value: 'Billing Number', path: 'BillingNumber' },
  { value: 'Brand ID', path: 'BrandID' },
  { value: 'Estimate Carrier', path: 'EstimateCarrier' },
  { value: 'Estimate Carrier Account ID', path: 'EstimateCarrierAccountID' },
  { value: 'Estimate Method', path: 'EstimateMethod' },
  { value: 'Estimate Transit Days', path: 'EstimateTransitDays' },
  { value: 'Shipment ID', path: 'ShipmentID' },
  { value: 'Date Shipped', path: 'DateShipped' },
  { value: 'Tracking Number', path: 'TrackingNumber' },
  { value: 'Service', path: 'Service' },
]