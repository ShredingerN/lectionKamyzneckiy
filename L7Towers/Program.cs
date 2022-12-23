// головоломка с пирамидками: переместить по порядку колечки с трех шпилей на один
// 1 - текущий шпиль, 2 - куда одеваем, 3  - промежуточный, count  - количество блинов
void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();