#include <iostream>
#include <ctime>

using namespace std;

int main() {
  char str[64];

  // Get the current system time.
  time_t t = time(NULL);

  // Show standard time and date string.
  strftime(str, 64, "%c", localtime(&t));
  cout << "Standard format: " << str << endl;

  return 0;
}