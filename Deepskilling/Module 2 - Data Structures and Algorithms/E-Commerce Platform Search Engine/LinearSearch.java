public class LinearSearch {

    public static Product search(Product[] products, String target) {

        for (Product product : products) {

            if (product.getName().equalsIgnoreCase(target)) {
                return product;
            }

        }

        return null;
    }

}
