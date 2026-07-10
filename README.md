# How-to-Adjust-Bottom-Sheet-Width-in-.NET-MAUI
This repository provides a sample that demonstrates how to customize the width of the Syncfusion® .NET MAUI Bottom Sheet.

**Adjust the Width of the .NET MAUI Bottom Sheet**

By default, the .NET MAUI Bottom Sheet occupies the full width of its parent container. You can customize its width by setting the WidthRequest property. This is useful when you want to display the Bottom Sheet as a centered dialog-like panel on larger screens such as tablets and desktops.

The following example demonstrates how to set a custom width for the Bottom Sheet.

**XAML**
```
<bottomSheet:SfBottomSheet
       x:Name="orderDetailsSheet"
       ContentWidthMode="Custom"
       BottomSheetContentWidth="500">

               <bottomSheet:SfBottomSheet.Content>
               <Border StrokeThickness="1" WidthRequest="400" HeightRequest="250" VerticalOptions="Start"
                         Padding="15"
                         Stroke="LightGray"
                        StrokeShape="RoundRectangle 10">

                   <Grid ColumnDefinitions="Auto,*">
                   <VerticalStackLayout Spacing="8">
                       <Label Text="Orders" FontSize="24" FontAttributes="Bold" Margin="0,0,0,20" />
                       <Label Text="Order #10245" FontSize="18" FontAttributes="Bold" />
                       <Label Text="Customer: John Smith" />
                       <Label Text="Order Date: 10-Jul-2026" />
                       <Label Text="Status: Shipped" TextColor="Green" />
                   </VerticalStackLayout>
                   <Button Text="View Details" HeightRequest="50" Grid.Column="1"
                                       HorizontalOptions="Center"
                                       Clicked="Button_Clicked" />
                   </Grid>

               </Border>
           </bottomSheet:SfBottomSheet.Content>
           <bottomSheet:SfBottomSheet.BottomSheetContent>

               <VerticalStackLayout Padding="20"
                                Spacing="12">

               <Label Text="Order Details"
                      FontSize="22"
                      FontAttributes="Bold" />
               <BoxView HeightRequest="1"
                        Color="LightGray"/>
               <Label Text="Order ID: #10245" />
               <Label Text="Customer: John Smith" />
               <Label Text="Order Date: 10-Jul-2026" />
               <Label Text="Status: Shipped" />
                <Label Text="Shipping Address: 123 Main Street, New York" />
               <Label Text="Total Amount: $299.99" />
               <Button Text="Track Order" />
               </VerticalStackLayout>

           </bottomSheet:SfBottomSheet.BottomSheetContent>

       </bottomSheet:SfBottomSheet>
```

 **C#:**

```
private void Button_Clicked(object sender, EventArgs e)
{
   orderDetailsSheet.IsOpen = true;
} 

```
