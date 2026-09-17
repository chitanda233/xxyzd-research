package com.tencent.turingfd.sdk.ams.ad;

import android.util.JsonWriter;
import androidx.core.app.NotificationCompat;
import java.io.IOException;
import java.io.StringWriter;
import java.util.Arrays;
import java.util.HashSet;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.package, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Cpackage {
    static {
        new HashSet();
        new HashSet();
    }

    public static String a() {
        String strA = q.f.a("s_h");
        if (strA == null || strA.isEmpty()) {
            return "";
        }
        HashSet<String> hashSet = new HashSet(Arrays.asList(strA.split(com.alipay.sdk.m.y.l.b)));
        StringWriter stringWriter = new StringWriter();
        JsonWriter jsonWriter = new JsonWriter(stringWriter);
        try {
            jsonWriter.beginObject();
            for (String str : hashSet) {
                jsonWriter.name(str);
                l0 l0VarA = Pomelo.a(str);
                jsonWriter.beginObject();
                jsonWriter.name("std");
                jsonWriter.value(l0VarA.f3944a);
                jsonWriter.name(NotificationCompat.CATEGORY_ERROR);
                jsonWriter.value(l0VarA.b);
                jsonWriter.endObject();
            }
            jsonWriter.endObject();
            return stringWriter.toString();
        } catch (IOException unused) {
            return "";
        }
    }
}
