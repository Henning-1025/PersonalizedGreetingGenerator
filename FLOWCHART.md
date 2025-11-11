```mermaid
graph TD
    A[Start] --> B{Get Current Date and Time}
    B --> C{Is Date and Time Available?}
    C -- Yes --> D[Extract Date]
    C -- Yes --> E[Extract Time]
    C -- No --> F[Display Error Message]
    D --> G[Display Day to the User]
    E --> H[Display Time to the User]
    G --> I[Display Full Message: "Good Day, Today is <Day> and Current Time is <Time>"]
    H --> I
    I --> J[End]