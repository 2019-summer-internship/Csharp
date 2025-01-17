﻿drop database if exists thesing;
create database thesing;
use thesing;

create table users (
	id int primary key comment '用户账号',
	flag bool not null default 1 comment '用户状态：1-激活，0-注销',
	name varchar(30) not null comment '用户姓名',
    age int comment '用户年龄',
    gender int comment '用户性别：1-无，2-女，3-男',
    pwd varchar(20) not null comment '用户密码',
    avatar varchar(255) comment '用户头像路径',
    type int not null comment '用户类型：1-学生，2-导师，3-学院，4-校方',
    phone varchar(11) comment '用户联系方式',
    email varchar(50) comment '用户邮箱'
)comment='用户表' character set=utf8;

create table student (
	_id int primary key comment '学生id',
    achievement varchar(30) comment '成绩id列表 -> 成绩表',
    class int not null comment '班级id -> 班级表',
    major int not null comment '专业id -> 专业表',
    school int not null comment '学院id -> 学院表',
    project int comment '题目id -> 题目表',
    teacher int comment '导师id -> 导师表'
)comment='学生表' character set=utf8;

create table teacher (
	_id int primary key comment '导师id',
    school int not null comment '学院id -> 学院表',
    title varchar(100) comment '头衔列表',
    introduction text comment '简介',
    students varchar(100) comment '所带学生id列表 -> 学生表',
    projects varchar(100) comment '所出题目id列表 -> 题目表'
)comment='导师表' character set=utf8;

create table school (
	_id int primary key auto_increment comment '学院id',
    name varchar(50) not null comment '学院名称',
    university int not null comment '所属学院id -> 学校表',
    schedules varchar(50) comment '学院日程安排'
)comment='学院表' character set=utf8;

create table university (
	_id int primary key auto_increment comment '学校id',
    name varchar(50) not null comment '学校名称',
    schools varchar(300) not null comment '下属学院id列表 -> 学院表'
)comment='学校表' character set=utf8;

create table class (
	_id int primary key auto_increment comment '班级id',
    school int not null comment '所属学院id -> 学院表',
    name varchar(50) not null comment '班级名称'
)comment='班级表' character set=utf8;

create table major (
	_id int primary key auto_increment comment '专业id',
    school int not null comment '所属学院id -> 学院表',
    name varchar(50) not null comment '专业名称'
)comment='专业表' character set=utf8;

create table project (
	_id int primary key auto_increment comment '题目id',
    name varchar(50) not null comment '题目名称',
    publish_time date not null comment '发布时间',
    teacher int not null comment '出题教师',
    student int comment '选题学生',
    manager int not null comment '审核学院',
    statu tinyint not null default 1 comment '题目状态：1-待审核，2-已发布，3-已被选',
    type varchar(50) not null comment '题目类型',
    form tinyint not null comment '题目来源：1-导师命题，2-学生自主命题',
    amount tinyint not null comment '工作量：1~5等级',
    difficult tinyint not null comment '难度：1~5等级',
    abstract text not null comment '摘要',
    background text not null comment '题目背景',
    requirement text not null comment '题目要求',
    enclosure varchar(500) comment '附件',
    tasks varchar(100) comment '进度id列表 -> 进度表'
)comment='题目表' character set=utf8;

create table message (
	_id int primary key auto_increment comment '消息id',
    sender int not null comment '发送者id -> 用户表',
    receiver int not null comment '接受者id -> 用户表',
    statu tinyint not null default 1 comment '状态：1-未读，2-已读',
    send_time datetime not null comment '发送时间',
    type tinyint not null comment '消息类型：1-文字，2-图片，3-文件',
    content text comment '内容',
    image varchar(100) comment '图片路径',
    file varchar(100) comment '文件路径',
    label varchar(50) comment '文件标签'
)comment='消息表' character set=utf8;

create table task (
    _id int primary key auto_increment comment '进度id',
    name varchar(50) comment '进度名称',
    project int not null comment '所属题目',
    label varchar(50) comment '标签',
    publish_time date not null comment '发布时间',
    statu tinyint not null default 1 comment '状态：1-未开始，2-正在进行，3-已完成'
)comment='进度表' character set=utf8;

create table mail (
	_id int primary key auto_increment comment '通知id',
    flag_sender bool not null default 1 comment '发送者是否删除标记',
    flag_receiver bool not null default 1 comment '接收者是否删除标记',
    sender int not null comment '发送者id -> 用户表',
    receiver int not null comment '接收者id -> 用户表',
    send_time datetime not null comment '发送时间',
    title varchar(100) not null comment '标题',
    content text not null comment '内容',
    statu tinyint not null default 1 comment '状态：1-未读，2-已读'
)comment='通知表' character set=utf8;

create table examine (
	_id int primary key auto_increment comment '评阅id',
    student int not null comment '所属学生id -> 学生表',
    teacher int not null comment '评阅导师id -> 导师表',
    score int not null comment '成绩',
    statu tinyint not null default 1 comment '状态：1-还未开始，2-正在进行，3-已经完成',
    files varchar(100) comment '文件id列表 -> 评阅文件表'
)comment='评阅表' character set=utf8;

create table examine_file (
	_id int primary key auto_increment comment '评阅文件id',
    examine int not null comment '所属评阅id -> 评阅表',
    file varchar(50) not null comment '评阅文件路径',
    score int comment '得分',
    feedback text comment '反馈',
    statu tinyint not null default 1 comment '状态：1-未开始，2-已完成'
)comment='评阅文件表' character set=utf8;

create table reconsider (
	_id int primary key auto_increment comment '复议id',
    applicant int not null comment '提出者id -> 用户表',
    manager int not null comment '审核学院id -> 学院表',
    student int not null comment '复议成绩所属学生',
    reason text not null comment '复议原因',
    statu tinyint not null default 1 comment '状态：1-未处理，2-已驳回，3-已接受'
)comment='复议表' character set=utf8;

create table achievement (
	_id int primary key auto_increment comment '成绩id',
    student int not null comment '所属学生id -> 学生表',
    score int comment '成绩',
    stage tinyint not null comment '阶段',
    consititution varchar(100) comment '成绩组成id列表 -> 成绩组成表'
)comment='成绩表' character set=utf8;

create table consititution (
	_id int primary key auto_increment comment '成绩组成id',
    achievement int not null comment '所属成绩id -> 成绩表',
    name varchar(50) comment '组成项名称',
    rate float not null comment '组成比例',
    score int comment '得分',
    teacher int comment '评分导师id -> 导师表',
    grade_time datetime comment '评分时间'
)comment='成绩组成表' character set=utf8;

create table shedule (
	_id int primary key auto_increment comment '日程id',
    flag bool not null default 0 comment '是否被删除：0-未删除，1-已删除',
    school int not null comment '所属学院id -> 学院表',
    stage tinyint not null comment '阶段：1-出题，2-选题，3-开题，4-中期，5-结题',
    satrt_time date not null comment '开始时间',
    end_time date not null comment '结束时间',
    content text comment '日程说明'
)comment='日程表' character set=utf8;


-- 插入数据
Insert into users(id,flag,name,age,gender,pwd,avatar,type,phone,email) values(2017112113,1,'JACK',19,2,'123456','document\picture1',1,'18230928888','1234567891@qq.com');
Insert into users(id,flag,name,age,gender,pwd,avatar,type,phone,email) values(1999121234,1,'Hu',49,3,'1234a','document\picture2',2,'15230926688','1230000891@qq.com');
Insert into users(id,flag,name,age,gender,pwd,avatar,type,phone,email) values(3001,1,'信息学院',12,1,'12345','document\picture3',3,'921688','1000899@qq.com');
Insert into users(id,flag,name,age,gender,pwd,avatar,type,phone,email) values(30,1,'SWJTU',129,1,'12345','document\picture4',4,'926688','1000891@qq.com');

Insert into student (_id,achievement,class,major,school,project,teacher) values (2017112113,'1',1,1,1,1,1999121234);
Insert into teacher(_id,school,title,introduction,students,projects) values (1999121234,1,'副教授','长江学者，专攻人工智能方面','2017112113','1');
Insert into school(_id,name,university,schedules) values (3001,'信息学院',1,'暂无');
Insert into university(_id,name,schools) values (30,'SWJTU','3001');

Insert into class(_id,school,name) values (1,3001,'软件工程二班');
Insert into major(_id,school,name) values (1,3001,'软件工程');
Insert into project(_id,name,publish_time,teacher,student,manager,statu,type,form,amount,difficult,abstract,background,requirement,enclosure,tasks) values(1,'人脸识别','2019-05-02',1999121234,2017112113,1,1,'人工智能',1,4,4,'属于人工智能的图形图像识别','随着人工智能的发展...','能在现有人脸识别上有所创新','关于人脸识别的算法合集文件','1');
Insert into message(_id,sender,receiver,statu,send_time,type,content,image,file,label) values (1,1999121234,2017112113,1,'2019-05-05 12:00:00',1,'你好，请仔细阅读附件','无','无','无');
Insert into task(_id,name,project,label,publish_time,statu) values (1,'初步设计文档',1,'人工智能','2019-04-28',2);
Insert into mail(_id,flag_sender,flag_receiver, sender,receiver,send_time,title,content,statu) values (1,0,0,1999121234,2017112113,'2019-05-05 09:10:00','选题结果','同学你好，你已选题成功',1);
Insert into examine(_id,student,teacher, score,statu,files) values (1,2017112113,1999121234,90,1,'00001');
Insert into examine_file(_id,examine,file,score,feedback,statu) values (1,1,'初步设计文档',89,'无',2);
Insert into reconsider 
(_id,applicant,manager,student,reason,statu) values (1,1999121234,3001,2017112113,'实际得分与本人评阅分数不符',2);
Insert into achievement(_id,student,score,stage,consititution) values (1,2017112113,80,1,'1');
Insert into consititution(_id,achievement,name,rate,score,teacher,grade_time) values (1,1,'文档',0.8,'88',1999121234,'2019-05-08 09:10:00');
Insert into shedule(_id,flag,school,stage,satrt_time,end_time,content) values (1,0,3001,3,'2019-05-05','2019-05-08','开题答辩');