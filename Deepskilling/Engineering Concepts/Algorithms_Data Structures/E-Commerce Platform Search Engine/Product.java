public class Product implements Comparable<Product> {
    private int id;
    private String name;
    private String category;

    public Product(int id, String name, String category) {
        this.id = id;
        this.name = name;
        this.category = category;
    }

    public String getName() {
        return name;
    }

    @Override
    public int compareTo(Product other) {
        return this.name.compareToIgnoreCase(other.name);
    }

    @Override
    public String toString() {
        return "Product{id=" + id + ", name='" + name + "', category='" + category + "'}";
    }
}
