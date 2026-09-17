package com.sigmob.sdk.videocache;

import android.text.TextUtils;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes4.dex */
class f {
    private static final Pattern d = Pattern.compile("[R,r]ange:[ ]?bytes=(\\d*)-");
    private static final Pattern e = Pattern.compile("GET /(.*) HTTP");

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f3660a;
    public final long b;
    public final boolean c;

    public f(String request) {
        n.a(request);
        long jA = a(request);
        this.b = Math.max(0L, jA);
        this.c = jA >= 0;
        this.f3660a = b(request);
    }

    private long a(String request) {
        Matcher matcher = d.matcher(request);
        if (matcher.find()) {
            return Long.parseLong(matcher.group(1));
        }
        return -1L;
    }

    public static f a(InputStream inputStream) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(inputStream, "UTF-8"));
        StringBuilder sb = new StringBuilder();
        while (true) {
            String line = bufferedReader.readLine();
            if (TextUtils.isEmpty(line)) {
                return new f(sb.toString());
            }
            sb.append(line).append('\n');
        }
    }

    private String b(String request) {
        Matcher matcher = e.matcher(request);
        if (matcher.find()) {
            return matcher.group(1);
        }
        throw new IllegalArgumentException("Invalid request `" + request + "`: url not found!");
    }

    public String toString() {
        return "GetRequest{rangeOffset=" + this.b + ", partial=" + this.c + ", uri='" + this.f3660a + "'}";
    }
}
