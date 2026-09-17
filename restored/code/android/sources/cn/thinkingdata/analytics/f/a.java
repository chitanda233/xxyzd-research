package cn.thinkingdata.analytics.f;

import android.content.Context;
import android.text.TextUtils;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.utils.TDLog;
import java.util.TimeZone;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final b f104a;
    private final Object b = new Object();
    private final Object c = new Object();
    private final Object d = new Object();

    public a(Context context, String str) {
        this.f104a = new b(context, str);
    }

    public String a(boolean z, Context context) {
        String strC;
        synchronized (this.b) {
            strC = (String) this.f104a.get(5);
            if (TextUtils.isEmpty(strC) && z) {
                strC = d.a(context).c();
                if (!TextUtils.isEmpty(strC)) {
                    this.f104a.save(5, strC);
                    d.a(context).a();
                }
            }
        }
        return strC;
    }

    public void a() {
        synchronized (this.c) {
            this.f104a.save(3, null);
        }
    }

    public void a(String str) {
        if (str == null) {
            return;
        }
        try {
            synchronized (this.d) {
                JSONObject jSONObject = (JSONObject) this.f104a.get(10);
                jSONObject.remove(str);
                this.f104a.save(10, jSONObject);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void a(String str, boolean z) {
        try {
            if (TextUtils.isEmpty(str)) {
                TDLog.d("ThinkingAnalytics.Storage", "The account id cannot be empty.");
                if (z) {
                    throw new cn.thinkingdata.analytics.h.l("account id cannot be empty");
                }
            } else {
                synchronized (this.b) {
                    if (!str.equals(this.f104a.get(5))) {
                        this.f104a.save(5, str);
                    }
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void a(JSONObject jSONObject, TimeZone timeZone, boolean z) {
        if (jSONObject != null) {
            try {
                if (cn.thinkingdata.analytics.h.g.a(jSONObject)) {
                    synchronized (this.d) {
                        JSONObject jSONObject2 = (JSONObject) this.f104a.get(10);
                        q.a(jSONObject, jSONObject2, timeZone);
                        this.f104a.save(10, jSONObject2);
                    }
                    return;
                }
            } catch (Exception e) {
                e.printStackTrace();
                return;
            }
        }
        if (z) {
            throw new cn.thinkingdata.analytics.h.l("Set super properties failed. Please refer to the SDK debug log for details.");
        }
    }

    public void a(boolean z) {
        this.f104a.save(0, Boolean.valueOf(z));
    }

    public void b() {
        synchronized (this.b) {
            this.f104a.save(5, null);
        }
    }

    public void b(String str, boolean z) {
        if (TextUtils.isEmpty(str)) {
            TDLog.w("ThinkingAnalytics.Storage", "The identity cannot be empty.");
            if (z) {
                throw new cn.thinkingdata.analytics.h.l("distinct id cannot be empty");
            }
        } else {
            synchronized (this.c) {
                this.f104a.save(3, str);
            }
        }
    }

    public void b(boolean z) {
        this.f104a.save(6, Boolean.valueOf(z));
    }

    public void b(boolean z, Context context) {
        try {
            synchronized (this.b) {
                try {
                    this.f104a.save(5, null);
                    if (z && !TextUtils.isEmpty(d.a(context).c())) {
                        d.a(context).a();
                    }
                } catch (Throwable th) {
                    throw th;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void c() {
        synchronized (this.d) {
            this.f104a.save(10, new JSONObject());
        }
    }

    public void c(boolean z) {
        this.f104a.save(7, Boolean.valueOf(z));
    }

    public boolean d() {
        return ((Boolean) this.f104a.get(0)).booleanValue();
    }

    public String e() {
        String str;
        synchronized (this.c) {
            str = (String) this.f104a.get(3);
        }
        return str;
    }

    public boolean f() {
        return ((Boolean) this.f104a.get(6)).booleanValue();
    }

    public boolean g() {
        return ((Boolean) this.f104a.get(7)).booleanValue();
    }

    public JSONObject h() {
        JSONObject jSONObject;
        synchronized (this.d) {
            jSONObject = (JSONObject) this.f104a.get(10);
        }
        return jSONObject;
    }
}
