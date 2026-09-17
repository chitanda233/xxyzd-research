package com.kwai.library.ipneigh;

import java.io.BufferedReader;
import java.io.Closeable;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;

/* JADX INFO: loaded from: classes3.dex */
final class a {

    interface b<T> {
        T b(BufferedReader bufferedReader);
    }

    public static String iH(String str) {
        try {
            return (String) a(str, new b<String>() { // from class: com.kwai.library.ipneigh.a.1
                @Override // com.kwai.library.ipneigh.a.b
                public final /* synthetic */ String b(BufferedReader bufferedReader) {
                    return a(bufferedReader);
                }

                private static String a(BufferedReader bufferedReader) throws IOException {
                    String line = bufferedReader.readLine();
                    while (bufferedReader.readLine() != null) {
                    }
                    return line;
                }
            });
        } catch (IOException | InterruptedException unused) {
            return null;
        }
    }

    private static <T> T a(String str, b<T> bVar) throws Throwable {
        BufferedReader bufferedReader;
        Process process = null;
        try {
            Process processExec = Runtime.getRuntime().exec(str);
            try {
                C0543a c0543a = new C0543a(processExec.getErrorStream());
                c0543a.start();
                bufferedReader = new BufferedReader(new InputStreamReader(processExec.getInputStream()));
                try {
                    T tB = bVar.b(bufferedReader);
                    c0543a.join();
                    processExec.waitFor();
                    if (processExec != null) {
                        processExec.destroy();
                    }
                    closeQuietly(bufferedReader);
                    return tB;
                } catch (Throwable th) {
                    th = th;
                    process = processExec;
                    if (process != null) {
                        process.destroy();
                    }
                    closeQuietly(bufferedReader);
                    throw th;
                }
            } catch (Throwable th2) {
                th = th2;
                bufferedReader = null;
            }
        } catch (Throwable th3) {
            th = th3;
            bufferedReader = null;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void closeQuietly(Closeable closeable) {
        if (closeable != null) {
            try {
                closeable.close();
            } catch (IOException unused) {
            }
        }
    }

    /* JADX INFO: renamed from: com.kwai.library.ipneigh.a$a, reason: collision with other inner class name */
    static class C0543a extends Thread {
        private final InputStream bvb;

        public C0543a(InputStream inputStream) {
            super("NoopStreamConsumer");
            this.bvb = inputStream;
        }

        @Override // java.lang.Thread, java.lang.Runnable
        public final void run() throws Throwable {
            BufferedReader bufferedReader;
            Throwable th;
            BufferedReader bufferedReader2 = null;
            try {
                bufferedReader = new BufferedReader(new InputStreamReader(this.bvb));
                do {
                    try {
                    } catch (IOException unused) {
                        bufferedReader2 = bufferedReader;
                        a.closeQuietly(bufferedReader2);
                        return;
                    } catch (Throwable th2) {
                        th = th2;
                        a.closeQuietly(bufferedReader);
                        throw th;
                    }
                } while (bufferedReader.readLine() != null);
                a.closeQuietly(bufferedReader);
            } catch (IOException unused2) {
            } catch (Throwable th3) {
                bufferedReader = null;
                th = th3;
            }
        }
    }
}
