package com.baidu.passbqt.http;

import com.baidu.passbqt.NoProguard;
import java.io.InputStream;

/* JADX INFO: loaded from: classes.dex */
public class MultipartHashMap extends HttpHashMap implements NoProguard {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public FileWrapper f625a;

    public void a(String str, InputStream inputStream, String str2, String str3) {
        this.f625a = new FileWrapper(str, inputStream, str2, str3);
    }

    static class FileWrapper {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public String f626a;
        public String b;
        public String c;
        public InputStream d;

        public FileWrapper(String str, InputStream inputStream, String str2, String str3) {
            this.f626a = str;
            this.d = inputStream;
            this.b = str2;
            this.c = str3;
        }

        public String a() {
            String str = this.b;
            return str != null ? str : "nofilename";
        }
    }
}
