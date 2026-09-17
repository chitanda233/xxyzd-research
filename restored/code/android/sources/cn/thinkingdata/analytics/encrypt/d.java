package cn.thinkingdata.analytics.encrypt;

/* JADX INFO: loaded from: classes.dex */
public class d implements a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    byte[] f102a;
    String b;

    @Override // cn.thinkingdata.analytics.encrypt.a
    public String a() {
        return "AES";
    }

    @Override // cn.thinkingdata.analytics.encrypt.a
    public String a(String str) {
        return c.a(this.f102a, str);
    }

    @Override // cn.thinkingdata.analytics.encrypt.a
    public String b() {
        return com.alipay.sdk.m.p.d.f334a;
    }

    @Override // cn.thinkingdata.analytics.encrypt.a
    public String b(String str) {
        try {
            byte[] bArrA = c.a();
            this.f102a = bArrA;
            String strA = c.a(str, bArrA);
            this.b = strA;
            return strA;
        } catch (Exception unused) {
            return null;
        }
    }
}
