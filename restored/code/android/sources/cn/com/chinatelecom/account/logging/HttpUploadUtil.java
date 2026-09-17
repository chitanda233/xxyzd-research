package cn.com.chinatelecom.account.logging;

import android.content.Context;
import android.text.TextUtils;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

/* JADX INFO: loaded from: classes.dex */
public class HttpUploadUtil {
    private static final String TAG = "HttpUploadUtil";

    /* JADX WARN: Code duplicated, block: B:43:0x00c0 A[Catch: Exception -> 0x00bc, TRY_LEAVE, TryCatch #0 {Exception -> 0x00bc, blocks: (B:39:0x00b8, B:43:0x00c0), top: B:47:0x00b8 }] */
    public static String doPost(Context context, String str, String str2) {
        InputStream inputStream;
        InputStream inputStream2;
        String string = "";
        BufferedReader bufferedReader = null;
        try {
            try {
                HttpURLConnection httpURLConnection = (HttpURLConnection) new URL(str).openConnection();
                httpURLConnection.setRequestProperty("accept", "*/*");
                httpURLConnection.setRequestMethod("POST");
                httpURLConnection.setDoOutput(true);
                httpURLConnection.setDoInput(true);
                httpURLConnection.setConnectTimeout(5000);
                httpURLConnection.setReadTimeout(5000);
                httpURLConnection.setUseCaches(false);
                httpURLConnection.addRequestProperty("Accept-Charset", "UTF-8");
                if (!TextUtils.isEmpty(str2)) {
                    DataOutputStream dataOutputStream = new DataOutputStream(new BufferedOutputStream(httpURLConnection.getOutputStream()));
                    dataOutputStream.write(str2.getBytes("UTF-8"));
                    dataOutputStream.flush();
                    dataOutputStream.close();
                } else {
                    httpURLConnection.connect();
                }
                if (httpURLConnection.getResponseCode() == 200) {
                    inputStream2 = httpURLConnection.getInputStream();
                    try {
                        StringBuilder sb = new StringBuilder();
                        BufferedReader bufferedReader2 = new BufferedReader(new InputStreamReader(inputStream2));
                        while (true) {
                            try {
                                String line = bufferedReader2.readLine();
                                if (line == null) {
                                    break;
                                }
                                sb.append(line).append("\n");
                            } catch (Throwable th) {
                                th = th;
                                bufferedReader = bufferedReader2;
                                Throwable th2 = th;
                                inputStream = inputStream2;
                                th = th2;
                                try {
                                    th.printStackTrace();
                                    if (bufferedReader != null) {
                                        bufferedReader.close();
                                    }
                                    if (inputStream != null) {
                                        inputStream.close();
                                    }
                                } catch (Throwable th3) {
                                    if (bufferedReader != null) {
                                        try {
                                            bufferedReader.close();
                                            if (inputStream != null) {
                                                inputStream.close();
                                            }
                                        } catch (Exception e) {
                                            e.printStackTrace();
                                            throw th3;
                                        }
                                    } else if (inputStream != null) {
                                        inputStream.close();
                                    }
                                    throw th3;
                                }
                            }
                        }
                        string = sb.toString();
                        bufferedReader = bufferedReader2;
                    } catch (Throwable th4) {
                        th = th4;
                    }
                } else {
                    inputStream2 = null;
                }
                if (bufferedReader != null) {
                    bufferedReader.close();
                }
                if (inputStream2 != null) {
                    inputStream2.close();
                }
            } catch (Throwable th5) {
                th = th5;
                inputStream = null;
            }
        } catch (Exception e2) {
            e2.printStackTrace();
        }
        return string;
    }
}
