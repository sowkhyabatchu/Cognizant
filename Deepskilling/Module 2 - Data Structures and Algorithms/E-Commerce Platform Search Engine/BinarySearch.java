public class BinarySearch {

    public static Product search(Product[] products, String target) {

        int left = 0;
        int right = products.length - 1;

        while (left <= right) {

            int mid = (left + right) / 2;

            int compare = products[mid].getName().compareToIgnoreCase(target);

            if (compare == 0) {
                return products[mid];
            }

            else if (compare < 0) {
                left = mid + 1;
            }

            else {
                right = mid - 1;
            }
        }

        return null;
    }

}
