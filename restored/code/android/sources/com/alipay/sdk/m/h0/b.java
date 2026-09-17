package com.alipay.sdk.m.h0;

import android.content.Context;
import java.io.File;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collections;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public File f292a;
    public com.alipay.sdk.m.l0.a b;

    public b(String str, com.alipay.sdk.m.l0.a aVar) {
        this.f292a = null;
        this.b = null;
        this.f292a = new File(str);
        this.b = aVar;
    }

    public static String a(String str) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("type", "id");
            jSONObject.put("error", str);
            return jSONObject.toString();
        } catch (Exception unused) {
            return "";
        }
    }

    public static String b() {
        return new SimpleDateFormat("yyyyMMdd").format(Calendar.getInstance().getTime()) + ".log";
    }

    public final synchronized void a() {
        File file = this.f292a;
        if (file == null) {
            return;
        }
        if (file.exists() && this.f292a.isDirectory() && this.f292a.list().length != 0) {
            ArrayList arrayList = new ArrayList();
            for (String str : this.f292a.list()) {
                arrayList.add(str);
            }
            Collections.sort(arrayList);
            String str2 = (String) arrayList.get(arrayList.size() - 1);
            int size = arrayList.size();
            if (str2.equals(b())) {
                if (arrayList.size() < 2) {
                    return;
                }
                str2 = (String) arrayList.get(arrayList.size() - 2);
                size--;
            }
            if (!this.b.logCollect(a(com.alipay.sdk.m.d0.b.a(this.f292a.getAbsolutePath(), str2)))) {
                size--;
            }
            for (int i = 0; i < size; i++) {
                new File(this.f292a, (String) arrayList.get(i)).delete();
            }
        }
    }

    public void a(Context context) {
        new Thread(new c(this)).start();
    }
}
