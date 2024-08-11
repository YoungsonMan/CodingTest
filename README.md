# CodeTestProgrammers

[프로그래머스](https://school.programmers.co.kr/learn/challenges?order=recent&levels=1&languages=csharp) 에서 지원하는 코딩 문제를 풀어봅니다.

### Goal 학습목표

---

- 가능하다면 매일 문제를 풀며 업데이트 합니다.

### Built with

---

Visual Studio 2022 v17.10.3

Laguage used - C#

## Explanation

---

[Programmers 웹사이트에 코딩 기초 트레이닝](https://school.programmers.co.kr/learn/challenges/training?order=acceptance_desc) 
차근차근 시작해보세요
프로그래머스가 준비한 일일 도전 과제 문제들을 매일 풀어 보세요! 우측 캘린더 메뉴에서 나의 일일 도전 과제 진행 현황을 확인할 수 있습니다.

## Day 1
* ### 문자열 출력하기
  문자열 str이 주어질 때, str을 출력하는 코드를 작성해 보세요.

  입력: HelloWorld!

  출력: HelloWorld!

* ### a와 b 출력
  정수 a와 b가 주어집니다. 각 수를 입력받아 입출력 예와 같은 형식으로 출력하는 코드를 작성해 보세요.

  입력: 4 5

  출력:

  a = 4

  b = 5

* ### 문자열 반복해서 출력
  문자열 str과 정수 n이 주어집니다. str이 n번 반복된 문자열을 만들어 출력하는 코드를 작성해 보세요.
  
  입력: string 5

  출력: stringstringstringstringstring

* ### 대소문자 변경
  영어 알파벳으로 이루어진 문자열 str이 주어집니다. 각 알파벳을 대문자는 소문자로 소문자는 대문자로 변환해서 출력하는 코드를 작성해 보세요.

  입력: aBcDeFg

  출력: AbCdEfG

* ### 특수문자 출력하기
  다음과 같이 출력하도록 코드를 작성해 주세요.(!@#$%^&*(\'"<>?:;)

## Day2
* ### 덧셈식 출력하기
  두 정수 a, b가 주어질 때 다음과 같은 형태의 계산식을 출력하는 코드를 작성해 보세요..

  입력: 4 5

  출력: 4 + 5 = 9

* ### 문자열 붙여서 출력하기
  두 개의 문자열 str1, str2가 공백으로 구분되어 입력으로 주어집니다.
  입출력 예와 같이 str1과 str2을 이어서 출력하는 코드를 작성해 보세요.

  입력: apple pen
  
  출력: applepen

  입력: Hello World!
  
  출력: HelloWorld!


* ### 문자열 돌리기
  문자열 str이 주어집니다.
  문자열을 시계방향으로 90도 돌려서 아래 입출력 예와 같이 출력하는 코드를 작성해 보세요.

  입력: abcde

  출력:
  
          a

          b

          c

          d

          e


* ### 홀짝 구분하기
  자연수 n이 입력으로 주어졌을 때 만약 n이 짝수이면 "n is even"을, 홀수이면 "n is odd"를 출력하는 코드를 작성해 보세요.

  입력1: 100

  출력1: 100 is even

  입력2: 1

  출력2: 1 is odd


* ### 문자열 겹쳐쓰기
  문자열 my_string, overwrite_string과 정수 s가 주어집니다.

  문자열 my_string의 인덱스 s부터 overwrite_string의 길이만큼을 문자열 overwrite_string으로 바꾼 문자열을 return 하는 solution 함수를 작성해 주세요.

  입출력 예

  | my_string | overwrite_string | s | result |
  | --- | --- | --- | --- |
  | "He11oWor1d" | "lloWorl" | 2 | "HelloWorld" |
  | "Program29b8UYP" | "merS123" | 7 | "ProgrammerS123" |


## Day 3 
* ### 문자열 섞기
  길이가 같은 두 문자열 str1과 str2가 주어집니다.
  두 문자열의 각 문자가 앞에서부터 서로 번갈아가면서 한 번씩 등장하는 문자열을 만들어 return 하는 solution 함수를 완성해 주세요.

  | str1 | str2 | result |
  | --- | --- | --- |
  | "aaaaa" | "bbbbb" | "ababababab" |


* ### 문자 리스트를 문자열료 변환하기
  문자들이 담겨있는 배열 arr가 주어집니다. arr의 원소들을 순서대로 이어 붙인 문자열을 return 하는 solution함수를 작성해 주세요.

  | arr | result |
  | --- | --- |
  | ["a","b","c"] | "abc" |

  
* ### 문자열 곱하기
  문자열 my_string과 정수 k가 주어질 때, my_string을 k번 반복한 문자열을 return 하는 solution 함수를 작성해 주세요.

  | my_string | k | result |
  | --- | --- | --- |
  | "string" | 3 | "stringstringstring" |
  | "love" | 10 | "lovelovelovelovelovelovelovelovelovelove" |


* ### 더 크게 합치기
  연산 ⊕는 두 정수에 대한 연산으로 두 정수를 붙여서 쓴 값을 반환합니다. 예를 들면 다음과 같습니다.

  12 ⊕ 3 = 123        3 ⊕ 12 = 312

  양의 정수 a와 b가 주어졌을 때, a ⊕ b와 b ⊕ a 중 더 큰 값을 return 하는 solution 함수를 완성해 주세요.

  단, a ⊕ b와 b ⊕ a가 같다면 a ⊕ b를 return 합니다.

  | a | b | result |
  | --- | --- | --- |
  | 9 | 91 | 991 |
  | 89 | 8 | 898 |

  
* ### 두 수의 연산값 비교하기
  연산 ⊕는 두 정수에 대한 연산으로 두 정수를 붙여서 쓴 값을 반환합니다. 예를 들면 다음과 같습니다.

  12 ⊕ 3 = 123            3 ⊕ 12 = 312

  양의 정수 a와 b가 주어졌을 때, a ⊕ b와 2 * a * b 중 더 큰 값을 return하는 solution 함수를 완성해 주세요.

  단, a ⊕ b와 2 * a * b가 같으면 a ⊕ b를 return 합니다.
  
  | a | b | result |
  | --- | --- | --- |
  | 2 | 91 | 364 |
  | 91 | 2 | 912 |


## Day 4
* ### n의 배수
  정수 num과 n이 매개 변수로 주어질 때, num이 n의 배수이면 1을 return n의 배수가 아니라면 0을 return하도록 solution 함수를 완성해주세요.

  | num | n | result |
  | --- | --- | --- |
  | 98 | 2 | 1 |
  | 34 | 3 | 0 |

  
* ### 공배수
  정수 number와 n, m이 주어집니다. number가 n의 배수이면서 m의 배수이면 1을 아니라면 0을 return하도록 solution 함수를 완성해주세요.

  | number | n | m | result |
  | --- | --- | --- | --- |
  | 60 | 2 | 3 | 1 |
  | 55 | 10 | 5 | 0 |


* ### 홀짝에 다른 값 반환하기
  양의 정수 n이 매개변수로 주어질 때, n이 홀수라면 n 이하의 홀수인 모든 양의 정수의 합을 return 하고

  n이 짝수라면 n 이하의 짝수인 모든 양의 정수의 제곱의 합을 return 하는 solution 함수를 작성해 주세요.

    | n | result |
    | --- | --- | 
    | 7 | 16 |
    | 10 | 220 |

  
* ### 조건 문자열
  문자열에 따라 다음과 같이 두 수의 크기를 비교하려고 합니다.

  두 수가 n과 m이라면

  ">", "=" : n >= m
  
  "<", "=" : n <= m

  ">", "!" : n > m

  "<", "!" : n < m

  두 문자열 ineq와 eq가 주어집니다. ineq는 "<"와 ">"중 하나고, eq는 "="와 "!"중 하나입니다.

  그리고 두 정수 n과 m이 주어질 때, n과 m이 ineq와 eq의 조건에 맞으면 1을 아니면 0을 return하도록 solution 함수를 완성해주세요.

  | ineq | eq | n | m | result |
  | --- | --- | --- | --- | --- |
  | "<" | "=" | 20 | 50 | 1 |
  | ">" | "!" | 41 | 78 | 0 |

* ### flag에 따라 다른 값 반환하기
  두 정수 a, b와 boolean 변수 flag가 매개변수로 주어질 때, flag가 true면 a + b를 false면 a - b를 return 하는 solution 함수를 작성해 주세요.

  | a | b | flag | result |
  | --- | --- | --- | --- |
  | -4 | 7 | true | 3 |
  | -4 | 7 | false | -11 |

  
## Day 5
* ### 코드 처리하기
  문자열 code가 주어집니다.

  code를 앞에서부터 읽으면서 만약 문자가 "1"이면 mode를 바꿉니다. mode에 따라 code를 읽어가면서 문자열 ret을 만들어냅니다.

  mode는 0과 1이 있으며, idx를 0 부터 code의 길이 - 1 까지 1씩 키워나가면서 code[idx]의 값에 따라 다음과 같이 행동합니다.
  * mode가 0일 때
    * code[idx]가 "1"이 아니면 idx가 짝수일 때만 ret의 맨 뒤에 code[idx]를 추가합니다.
    * code[idx]가 "1"이면 mode를 0에서 1로 바꿉니다.
  * mode가 1일 때
    * code[idx]가 "1"이 아니면 idx가 홀수일 때만 ret의 맨 뒤에 code[idx]를 추가합니다.
    * code[idx]가 "1"이면 mode를 1에서 0으로 바꿉니다.
  문자열 code를 통해 만들어진 문자열 ret를 return 하는 solution 함수를 완성해 주세요.
  
  단, 시작할 때 mode는 0이며, return 하려는 ret가 만약 빈 문자열이라면 대신 "EMPTY"를 return 합니다.

  | code | result |
  | --- | --- |
  | "abc1abc1abc" | "acbac" |

  입출력 예시 설명
  | i | code[i] | mode | ret |
  | --- | --- | --- | --- |
  | 0 | "a" | 0 | "a" |
  | 1 | "b" | 0 | "a" |
  | 2 | "c" | 0 | "ac" |
  | 3 | "1" | 1 | "ac" |
  | 4 | "a" | 1 | "ac" |
  | 5 | "b" | 1 | "acb" |
  | 6 | "c" | 1 | "acb" |
  | 7 | "1" | 0 | "acb" |
  | 8 | "a" | 0 | "acba" |
  | 9 | "b" | 0 | "acba" |
  | 10 | "c" | 0 | "acbac" |

  

  

gif
---- 
![240805_Day1](https://github.com/user-attachments/assets/aaf77dc6-abe1-4eaa-8307-102d4df1f5ba)

![240805_Day1_VS](https://github.com/user-attachments/assets/eb5d1c9c-fe13-42da-aa96-3ec79c897103)

![Day2](https://github.com/user-attachments/assets/89685d11-8993-4eb8-ab2e-0cde1f41c20c)


# Progress

---

### Daily improvement

- [x]  Day 1 출력
    - [x]  문자열 출력하기
    - [x]  a 와 b 출력하기
    - [x]  문자열 반복해서 출력하기
    - [x]  대소문자 바꿔서 출력하기
    - [x]  특수문자 출력하기
- [x]  Day 2 출력, 연산
    - [x]  덧셈식 출력하기
    - [x]  문자열 붙여서 출력하기
    - [x]  문자열 돌리기
    - [x]  홀짝 구분하기
    - [x]  문자열 겹쳐쓰기
- [x]  Day 3 연산
    - [x]  문자열 섞기
    - [x]  문자 리스트를 문자열로 변환하기
    - [x]  문자열 곱하기
    - [x]  더 크게 합치기
    - [x]  두 수의 연산값 비교하기
- [x]  Day 4 연산, 조건문
    - [x]  n의 배수
    - [x]  공배수
    - [x]  홀짝에 따라 다른 값 반환하기
    - [x]  조건 문자열
    - [x]  flag에 따라 다른 값 반환하기
- [ ]  Day 5 조건문
    - [ ]  코드 처리하기
    - [ ]  등차수열의 특정한 항만 더하기
    - [ ]  주사위 게임 2
    - [ ]  원소들의 곱과 합
    - [ ]  이어 붙인 수

## Comments

---

Day 1 
* 완료. 아직은 할만하다.

Day 2 
* 마지막문제(문자열 겹쳐쓰기)가 조금 햇갈렸다. "Substring" 

Day 3 
* 아직 다 못끝냈다. 4번째 문제 '더 크게 합치기에서' 효율이 안나와서 채점에서 반정도 실패하였다.
* 문제중에 더 크게 합치기에서 , 문자열을 더했을때 앞+뒤/뒤+앞  더 큰거를 뽑아야 되는데 그냥 합쳐서 출력만 했어서 안됐던거였다.

Day 4 
* 조건 문자열까지는 순조로웠었다.
* 문제를 좀 잘 읽고 풀어야 할 필요가 있다. 한두번도아니고...
* 몇시간 동안 박으면서 이게 "!", "=" 에서 "!"이 참이 아닐때 쓰는데, 왜 이게 있으면 입력값을 반대로 받아야 하는게 아닌가 생각때문에 더 했갈렸다.
  ex) >! 이게 이렇게 되면 오른쪽이 더 크다로 바꿔서 인식해야 된다던가...
  잘 안풀리다 보니 별의 별 이상한걸 다 시작 했던거 같다.
  문제를 읽으면서 지문하고 로직은 이해는 했는데 구현을 어떻게 해야 하는 쪽에서 막혔었다.
* 다른 사람들 풀이를 보니까 "?" 물음표를 많이 쓰던데 찾아봐도 뭔가 햇갈린다. 

Day 5 
* 음 여기도 이해는 했고 뭔가 알거같은데 아직 잘 안된다 조금더 박아봐야할거같다.
