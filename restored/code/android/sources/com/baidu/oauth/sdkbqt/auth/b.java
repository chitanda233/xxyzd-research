package com.baidu.oauth.sdkbqt.auth;

import android.os.AsyncTask;
import java.net.URL;
import java.net.URLConnection;

/* JADX INFO: loaded from: classes.dex */
class b extends AsyncTask<String, Void, Long> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private a f564a;

    public interface a {
        void a(long j);
    }

    b(a aVar) {
        this.f564a = aVar;
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // android.os.AsyncTask
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public Long doInBackground(String... strArr) {
        try {
            URLConnection uRLConnectionOpenConnection = new URL(strArr[0]).openConnection();
            uRLConnectionOpenConnection.setConnectTimeout(3000);
            uRLConnectionOpenConnection.connect();
            return Long.valueOf(uRLConnectionOpenConnection.getDate() / 1000);
        } catch (Exception e) {
            com.baidu.oauth.sdkbqt.a.d.a(e);
            return 0L;
        }
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // android.os.AsyncTask
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void onPostExecute(Long l) {
        a aVar = this.f564a;
        if (aVar != null) {
            aVar.a(l.longValue());
        }
    }
}
