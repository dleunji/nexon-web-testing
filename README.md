# 🎭 Playwright를 이용한 E2E 통합 테스트

[Playwright](https://playwright.dev/)란 Microsoft에서 제공하는 E2E 자동화된 테스트 도구입니다. 이를 이용하여 넥슨 홈페이지부터 충전창까지 결제 수단별 테스트를 진행하였습니다.

Playwright는 Node.js, Python, .NET, 그리고 Java와 같은 다양한 프레임워크(언어)를 지원합니다.  
그중 .NET을 사용하여 E2E 테스트를 진행하였습니다.

## ERD

![playwright (1)](https://user-images.githubusercontent.com/46207836/163950400-5ad68cfe-8e76-469c-9d16-b0b5d6fbaf68.png)

상단의 오른쪽 다이어그램과 같이 Playwright는 테스트에 필요한 탭을 사용범위에 따라 브라우저, 컨텍스트, 페이지 등을 베이스 인터페이스로 제공합니다.

세부적인 설정이 필요없는 경우에는 Page 클래스를 사용하면 되나, 통합 테스트 시 브라우저가 Visible하기를 원하여(`visibility=invisible` is default) playwright 최상위 베이스클래스를 오버라이딩하여 설정을 변경하였습니다.
