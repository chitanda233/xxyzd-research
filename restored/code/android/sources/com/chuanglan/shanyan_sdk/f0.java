package com.chuanglan.shanyan_sdk;

import com.chuanglan.shanyan_sdk.tool.OperatorInfoBean;
import com.chuanglan.shanyan_sdk.tool.ShanYanUIConfig;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/* JADX INFO: loaded from: classes2.dex */
public abstract class f0 {
    public static String a(String str) {
        Q.a("ProcessShanYanLogger", "name from", str);
        c();
        a(b());
        return d(str);
    }

    public static String b(String str) {
        Q.a("ProcessShanYanLogger", "url from", str);
        c();
        b(b());
        return f(str);
    }

    public static String c(String str) {
        Q.a("ProcessShanYanLogger", "slogan from", str);
        c();
        c(b());
        return e(str);
    }

    private static String d(String str) {
        str.hashCode();
        str.hashCode();
        switch (str) {
            case "CMHK":
                String str2 = AbstractC0606l.e;
                return str2 != null ? str2 : "中国移动香港认证服务条款";
            case "CTCC":
                String str3 = AbstractC0606l.f1988a;
                return str3 != null ? str3 : "天翼账号服务与隐私协议";
            case "CUCC":
                String str4 = AbstractC0606l.g;
                return str4 != null ? str4 : "中国联通认证服务协议";
            default:
                String str5 = AbstractC0606l.c;
                return str5 != null ? str5 : "中国移动认证服务条款";
        }
    }

    private static String e(String str) {
        str.hashCode();
        str.hashCode();
        switch (str) {
            case "CMHK":
                String str2 = AbstractC0606l.l;
                return str2 != null ? str2 : "中国移动香港提供认证服务";
            case "CTCC":
                String str3 = AbstractC0606l.j;
                return str3 != null ? str3 : "天翼账号提供认证服务";
            case "CUCC":
                String str4 = AbstractC0606l.i;
                return str4 != null ? str4 : "中国联通提供认证服务";
            default:
                String str5 = AbstractC0606l.k;
                return str5 != null ? str5 : "中国移动提供认证服务";
        }
    }

    private static String f(String str) {
        str.hashCode();
        str.hashCode();
        switch (str) {
            case "CMHK":
                String str2 = AbstractC0606l.f;
                return str2 != null ? str2 : "https://wap.cmpassport.com/uni-access/hkContactCm.html?language=SC";
            case "CTCC":
                String str3 = AbstractC0606l.b;
                return str3 != null ? str3 : "https://e.189.cn/sdk/agreement/detail.do?hidetop=true";
            case "CUCC":
                String str4 = AbstractC0606l.h;
                return str4 != null ? str4 : "https://auth.wosms.cn/html/oauth/protocol2.html";
            default:
                String str5 = AbstractC0606l.d;
                return str5 != null ? str5 : "https://wap.cmpassport.com/resources/html/contract.html";
        }
    }

    private static List a() {
        return Arrays.asList(new OperatorInfoBean("中国移动认证服务条款", "https://wap.cmpassport.com/resources/html/contract.html", "中国移动提供认证服务"), new OperatorInfoBean("中国联通认证服务协议", "https://auth.wosms.cn/html/oauth/protocol2.html", "中国联通提供认证服务"), new OperatorInfoBean("天翼账号服务与隐私协议", "https://e.189.cn/sdk/agreement/detail.do?hidetop=true", "天翼账号提供认证服务"), new OperatorInfoBean("中国移动香港认证服务条款", "https://wap.cmpassport.com/uni-access/hkContactCm.html?language=SC", "中国移动香港提供认证服务"));
    }

    private static List b() {
        ShanYanUIConfig shanYanUIConfigA = com.chuanglan.shanyan_sdk.tool.a.b().a();
        return shanYanUIConfigA.getOperatorInfo() != null ? new ArrayList(shanYanUIConfigA.getOperatorInfo()) : a();
    }

    private static void c() {
        t0.h().m();
    }

    private static void a(List list) {
        if (list == null || list.isEmpty()) {
            return;
        }
        try {
            if (list.size() >= 3) {
                AbstractC0606l.c = ((OperatorInfoBean) list.get(0)).getOperatorName();
                AbstractC0606l.g = ((OperatorInfoBean) list.get(1)).getOperatorName();
                AbstractC0606l.f1988a = ((OperatorInfoBean) list.get(2)).getOperatorName();
            }
            if (list.size() >= 4) {
                AbstractC0606l.e = ((OperatorInfoBean) list.get(3)).getOperatorName();
            }
        } catch (Exception e) {
            Q.a("ProcessShanYanLogger", "updateBaseConstantsOperatorPrivacyNameIfNeeded", e);
        }
    }

    private static void c(List list) {
        if (list == null || list.isEmpty()) {
            return;
        }
        try {
            if (list.size() >= 3) {
                AbstractC0606l.k = ((OperatorInfoBean) list.get(0)).getOperatorSloganName();
                AbstractC0606l.i = ((OperatorInfoBean) list.get(1)).getOperatorSloganName();
                AbstractC0606l.j = ((OperatorInfoBean) list.get(2)).getOperatorSloganName();
            }
            if (list.size() >= 4) {
                AbstractC0606l.l = ((OperatorInfoBean) list.get(3)).getOperatorSloganName();
            }
        } catch (Exception e) {
            Q.a("ProcessShanYanLogger", "updateBaseConstantsOperatorPrivacyUrlIfNeeded", e);
        }
    }

    private static void b(List list) {
        if (list == null || list.isEmpty()) {
            return;
        }
        try {
            if (list.size() >= 3) {
                AbstractC0606l.d = ((OperatorInfoBean) list.get(0)).getOperatorUrl();
                AbstractC0606l.h = ((OperatorInfoBean) list.get(1)).getOperatorUrl();
                AbstractC0606l.b = ((OperatorInfoBean) list.get(2)).getOperatorUrl();
            }
            if (list.size() >= 4) {
                AbstractC0606l.f = ((OperatorInfoBean) list.get(3)).getOperatorUrl();
            }
        } catch (Exception e) {
            Q.a("ProcessShanYanLogger", "updateBaseConstantsOperatorPrivacyUrlIfNeeded", e);
        }
    }
}
