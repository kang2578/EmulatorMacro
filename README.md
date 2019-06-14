﻿
연결 프로세스의 화면을 분석해서 키보드나 마우스 이벤트 반복

<img src="https://github.com/EomTaeWook/EmulatorMacro/blob/master/Release/Resource/capture.png" width="100%"></img>


다운로드 : https://github.com/EomTaeWook/EmulatorMacro/releases


개발환경

    WPF, C#, .net 4.7.1

    UI toolkit : MahApps.metro
    
OS 버전

    Window 8.0 이상

주의 사항

	1.Macro 실행시 앱플레이어 이미지에 여백이 발생하는 경우

		- Datas\ApplicationData.json => IsDynamic [true][false]를 변경하시면 됩니다.

	2.주 모니터 확대 비율이 더 높아야합니다.

		-주 모니터 DPI 100% 보조 모니터 150%인 경우에 대해선 기능을 처리 하지 않았습니다. 주 모니터 150%, 보조 모니터 100% 이런 식이 되어야 합니다.

사용 방법
    
    1.트리거 저장

        1.1 화면 캡쳐 버튼를 통하여 찾고 싶은 이미지 캡쳐
    
        1.2 Image, Mouse, Keyboard, RelativeToImage 이벤트 선택
    
            1.2.1 Image : 찾은 이미지를 클릭합니다.
                
                - 찾은 이미지 내에서 랜덤 클릭합니다.(좌표 패턴화 되는 것을 방지합니다.)

                - 고정된 좌표를 클릭하는 마우스 이벤트보다 우선시 해주세요.

            1.2.2 Mouse : 좌표 지정(좌클릭, 우클릭, 드래그) 해주시면 됩니다.
        
            1.2.3 Keyboard : Ctrl + c + v 이런식으로 조합키를 넣어주면 됩니다.

            1.2.4 RelativeToImage : 찾은 이미지로부터 +- 한 거리를 클릭합니다.(아이디어 Ko9ma7 제공)
        
        1.3 실행시 이미지를 캡쳐할 실행 프로세스를 선택하시면 됩니다.

        1.4 후 작업 딜레이

            - 현재 작업이 완료 이후 어느 정도 대기를 한 후 다음 작업을 하고 싶은 경우에 사용하시면 됩니다.(아이디어 Ko9ma7 제공)

            - ex> 버튼 클릭 => 팝업 뜨기까지 대기 => 확인 버튼 클릭 (연계하는 경우)

        1.5 아이템 반복
        
            - 한번 : 한번만 발생합니다.

            - 횟수 : 횟수만큼 반복 실행합니다.

            - 검색 결과가 없을 때까지 : 하위 아이템 하나라도 실행이 된다면 반복해서 실행됩니다.(하나라도 실행이 안되면 다음 Item으로 넘어갑니다.)

            - 검색 이미지를 찾을 때까지 : 상위 이미지를 찾을때까지 하위 이벤트를 반복 실행합니다.(상위 아이템을 발견시 다음 Item으로 넘어갑니다.)

        1.6 저장

    2.드래그 앤 드랍으로 트리 노드 순서도 변경

        2.1 상위 아이템 밑으로 드래그 앤 드랍시 자식 노드로 추가

        2.2 자식 아이템을 상위 아이템 포커싱 밖으로 드래그 앤 드랍시 최상위 노드로 추가

            - 우측 스크롤 쪽 또는 제일 하단 또는 트리 컬럼 쪽

    3.여러 게임의 세이브 파일을 저장하고 싶은 경우 setting에서 세이브 경로를 다르게 하여 저장하세요.

    4.연결 프로세스 리스트 
        
        - 프로세스가 목록에 없는 경우 또는 종료되거나 새로운 프로세스를 실행 시켰을시엔 새로고침 버튼을 눌러주세요.

        - 연결 프로세스를 고정하게 되면 save된 프로세스 이름으로 전체를 검색하는 것이 아닌 고정된 프로세스에서만 검색하게 됩니다.(녹스 여러개 대응)    

    5.바로가기

        - 입력된 이벤트로 바로 이동합니다.

※ 이미지 조합을 통한 이벤트 발생 방법

<img src="https://github.com/EomTaeWook/EmulatorMacro/blob/master/Release/Resource/imageCombination.png" width="100%"></img>

설정(Config.json 혹은 프로그램 내 Setting)

    1.Language 언어 : [Eng],[Kor]
    
    2.SavePath : 설정 리스트 save 경로
    
    3.Period : 전체 작업 완료 이후 딜레이

    4.ItemDelay : 트리거 아이템 작업 완료 다음 작업까지 딜레이(공통)
    
    5.Similarity : 이미지 프로세싱 유사도

    6.SearchResultDisplay : [true],[false] : 이미지 검색 결과 표시 여부

    7.VersionCheck : [true],[false] : 프로그램 실행시 버전 체크 확인

작업 목록

    12.마우스 휠 기능 숫자로 입력 => 드래그 기능이 구현되어 있지만 휠 기능으로 보완(작업중, 추후 업데이트)

		- 기능 자체는 완료되었으나 테스트 결과 각각의 Child 창 조사 및 창의 마우스 좌표계가 아닌 전체 스크린 영역의 마우스 좌표계 적용된다는 점. 

		- Wheel Event를 받는 Child 창을 다 조사해야하고 현재 구조를 또 바꿔야함.
        

버그 레포팅

    enter0917@naver.com

릴리즈
2.4.0

    1.바로가기 기능 추가

    2.Target 버전 .Net 4.7.1 변경(닷넷 프레임워크 4.7.1 이상 필요합니다.)

    3.패쳐 수정

2.3.6

    1.복사 기능 추가

2.3.5

    1.Peak 지원
    
    2.위치 변경시 저장 버튼 눌러야 적용 => 자동 저장 변경

2.3.4

    1.LDPlayer 지원

    - DPI 기능, 좌표가 안 맞는 경우 Datas/ApplicationData.json 에서 설정하시면 됩니다.

2.3.3

    1.반복 기능 추가

    2.이미지 이벤트 클릭 변경

    - 찾은 이미지 내에서 랜덤 클릭(클릭 이벤트 좌표계 패턴화 되는 것을 막습니다.)

    - 마우스 클릭보다 우선시 해주세요.

2.3.1

    - 키보드 이벤트 오류 수정

2.3.0

    2019-02-07 Feedback

    1.찾은 이미지로부터 +- 한 좌표 클릭 이벤트 추가

    2.이미지 검색 결과 표시 여부 추가(setting)

2.2.1

    - 버그 수정

2.2.0

    1.하위 아이템 반복 기능 추가

    2.선택시 삭제 버튼 안 보이는 버그 수정

2.1.0

    1.마우스 이벤트 드래그 기능 추가

    2.연결 프로세스 고정 기능 추가

2.0.0

    1.기존의 Save 파일은 지원 안됩니다.

    2.이벤트 목록 트리 형식으로 변경

    - 자식 노드가 있는 경우 이미지를 검색만 합니다.

    - 자식 노드가 없는 경우 이벤트가 발생됩니다.

    - 사용 방법

        드래그 앤 드랍으로 노드 레벨을 변경합니다.

        클릭하고 버튼으로 위치 이동

    ex) item 이미지 검색

        ㄴ item 이미지 검색

            ㄴ item 트리거 발생

        ㄴ item 이미지 검색
        
    3.버그 수정

1.4.4

    1.리스트 드래그 앤 드랍 방식 변경

    2.이벤트 타입 키보드인 경우 저장 안되는 현상 수정

    3.성능 개선

    4.이벤트 타입 추가

    5.설정 최소 값 100ms 통일

1.4.3

    - DPI 버그 수정, SavePath 팝업으로 저장시 불러오기 제대로 안되는 부분 수정, 최소 설정 값 수정, 라벨 변경

1.4.2

    - 단일 작업별 후 딜레이 적용 안되는 버그 수정

1.4.1

    - 리스트 아이템 드래그 앤 드랍시 순서도 정확하게 변경 안되는 버그 수정

1.4.0

    2019-01-15 Feedback

    1.단일 작업별 후 딜레이 설정(후 딜레이 => 아이템 개별 설정)

    2.버전 체크 옵션화

    3.저장 방식 변경 =>

    트리거 아이템 변경시 원본을 남겨두고 마지막에 추가 방식 => 트리거 아이템 원본 수정

1.3.1

    - 모니터별 해상도 별 이미지 프로세싱 작업 완료, 마우스 이벤트 좌표계 버그 수정

1.3.0

    - 리스트 Drag And Drop으로 순서 변경 기능 추가

1.2.2

    - 버전 체크 및 Install 파일 변경

1.2.1

    1.Mouse Event 방식 변경

    2.물리적인 마우스 이벤트 -> 논리적 마우스 이벤트 방식의 변경

    3.프로그래스바 버그 수정

1.2.0 

    1.setting view 추가

    2019-01-09 Feedback

    2.작업간의 중간 딜레이 설정 기능 추가, 딜레이를 통한 CPU 사용률 저하 확인

1.1.1

    - UI 비동기 처리가 안 되어서 프로그램이 응답없음 뜨는 오류 수정.

1.1.0

    - 세이브 파일 확장성 고려 및 에뮬레이터 사이즈 변경없이 이동시키는 경우 마우스 보정 작업

1.0.0 

    - 기본 기능 완료