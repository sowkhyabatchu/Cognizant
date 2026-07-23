import java.util.Arrays;

public class Main {

    public static void main(String[] args) {

        Product[] products = {

                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Mouse", "Electronics"),
                new Product(3, "Keyboard", "Electronics"),
                new Product(4, "Notebook", "Office"),
                new Product(5, "Desk Lamp", "Home")

        };

        // Linear Search
        System.out.println("Linear search: find 'Notebook'");

        Product linearResult = LinearSearch.search(products, "Notebook");

        if (linearResult != null)
            System.out.println("Found: " + linearResult);
        else
            System.out.println("Product not found");

        // Sort before Binary Search
        Arrays.sort(products);

        // Binary Search
        System.out.println("\nBinary search: find 'Desk Lamp'");

        Product binaryResult = BinarySearch.search(products, "Desk Lamp");

        if (binaryResult != null)
            System.out.println("Found: " + binaryResult);
        else
            System.out.println("Product not found");
    }

}
