# 🛶 Orangutan Riddle River 🦧

**Description:**
You are kayaking down a calm jungle river when a clever **orangutan** blocks your path. To continue your journey, you must answer **three riddles** correctly. You start with **three chances**. each wrong answer costs you one. The orangutan will decide whether you are allowed to pass based on how many riddles you solve.

---

## **Gameplay Instructions**

1. **Start the game:**
   Run the program in a C# console environment.

2. **Enter your name:**
   The orangutan will ask for your name to personalize the adventure.

3. **Answer the riddles:**

   Riddles **MUST** be answered with numbers provided or else the game will not consider it a valid answer and may crash.

4. **Lives/Chances:**

   * You start with **3 lives**.
   * Each incorrect answer **reduces a life by 1**.
   * If you lose all lives, you get the failure ending.

5. **Endings:**

   * **True Ending:** Answer all riddles correctly with all lives intact.
   * **Partial Success:** Lose 1–2 lives, but still pass.
   * **Failure:** Lose all 3 lives, and the orangutan sends you back.

6. **Finish:**
   After the final riddle, the game will display your ending and wait for you to press a key to exit.

---

### **Key Features / Learning Points**

* Console input/output (`Console.WriteLine` and `Console.ReadLine`)
* String interpolation and concatenation
* Logical and comparison operators
* Conditional statements (`if` / `else`)
* Variables in camelCase and lives counting
* Parsing numeric input safely using `int.TryParse`
